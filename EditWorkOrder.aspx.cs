using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using ReliantUtilityLibrary;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Reliant.RenuOil.DAL.Linq;
using Telerik.Web.UI.Calendar;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using System.Collections;
using Reliant.RenuOil.Business.WorkOrderManagement;
using System.Configuration;
using System.IO;
using Reliant.RenuOil.Business.DocumentGeneration;
using System.Net.Mail;
using System.Net;
using Reliant.RenuOil.DAL.CollectionClasses;
using Reliant.RenuOil.DAL.HelperClasses;

namespace RenuOil
{
    public partial class EditWorkOrder : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private WorkOrderEntity _workOrder = null;
        private int _workOrderId = 0;
        private AccountEntity _account = null;
        private List<EmployeeEntity> _employees = null;
        private List<ServiceLocationEntity> _serviceLocations = null;
        private int bagsTotal = 0;
        private int balesTotal = 0;
        private decimal bagswt = 0;
        private decimal baleswt = 0;
        private int _recycleServiceId = 0;
        public SessionManager sm
        {
            get
            {
                if (Session["SessionManager"] == null)
                {
                    Session["SessionManager"] = new SessionManager();
                }
                return (SessionManager)Session["SessionManager"];
            }
            set
            {
                Session["SessionManager"] = value;
            }
        }

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            int accountId = 0;
            int serviceType = 0;

            if (!IsPostBack)
            {
                // check to see if this is from beginworkorder                
                if (int.TryParse(Request.QueryString["acctId"], out accountId))
                {
                    int.TryParse(Request.QueryString["serviceType"], out serviceType);
                }
            }

            int workOrderId = 0;
            int.TryParse(Request.QueryString["id"], out workOrderId);

            int newSave = 0;
            int.TryParse(Request.QueryString["newSave"], out newSave);

            if (workOrderId > 0)
            {
                _workOrderId = workOrderId;
                _workOrder = new WorkOrderEntity(workOrderId);
                _account = _workOrder.Account;
                _serviceLocations = (from sl in _db.ServiceLocation
                                     where sl.AccountId == _account.AccountId
                                     orderby sl.Name
                                     select sl).ToList();

                btnPrintWorkOrder.Focus();
            }
            else
            {
                _workOrder = new WorkOrderEntity();
                if (serviceType != 0)
                {
                    _workOrder.ServiceTypeId = serviceType;
                }
                if (accountId != 0)
                {
                    _workOrder.AccountId = accountId;
                }
            }

            _employees = (from emp in _db.Employee
                          where emp.IsActive
                          orderby emp.FirstName, emp.LastName
                          select emp).ToList();

            if (newSave == 1)
            {
                messages.Add(HtmlHelper.Div("success", "Work order saved."));
            }
            else
            {
                messages.InnerHtml = "";
            }

            imgSignature.Visible = false;
            lblSignature.Visible = false;

            if (!Page.IsPostBack)
            {
                var accounts = (from a in _db.Account
                                orderby a.Name
                                select a).ToList();

                ddlAccount.Items.Clear();
                ListItem li = new ListItem("", "");
                ddlAccount.Items.Add(li);

                ddlDocks.Items.Clear();
                ListItem li1 = new ListItem("", "");
                ddlDocks.Items.Add(li1);

                ddlTechnician.Items.Clear();
                ListItem li2 = new ListItem("", "");
                ddlTechnician.Items.Add(li2);

                foreach (var employee in _employees)
                {
                    ListItem emp = new ListItem(employee.FirstName + " " + employee.LastName, employee.EmployeeId.ToString());
                    ddlTechnician.Items.Add(emp);
                }

                multiView.ActiveViewIndex = 0;
                // hide controls until we know what kind of work order this
                divFryerAccount.Visible = false;
                divAssetReclamationAccount.Visible = false;
                divRecycle.Visible = false;
                btnSaveWorkOrder.Visible = false;
                btnCancel.Visible = false;

                if (serviceType != 0)
                {
                    ddlWorkOrderType.SelectedValue = serviceType.ToString();
                }
                populate();

                if (sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
                {
                    rdServiceLocationsGrid.Enabled = false;
                    rdAssetTypeGrid.Enabled = false;
                    divSaveCancel1.Visible = false;
                    divSaveCancel2.Visible = false;
                    rdDateWorkOrderDate.Enabled = false;
                    rdTimeApptTime.Enabled = false;
                    txtNotes.Enabled = false;
                }
            }

            rdServiceLocationsGrid.MasterTableView.GetColumn("ExpandColumn").Visible = false;

            if (accountId != 0)
            {
                ddlAccount.SelectedValue = accountId.ToString();
            }
        }

        #endregion

        #region Methods
        protected void btnPrintWorkOrder_Click(object sender, EventArgs e)
        {
            try
            {
                WorkOrderDocument wod = new WorkOrderDocument(_workOrderId);
                publishReportForWeb(wod.Generate());
            }
            catch (Exception ex)
            {
                messages.AddErrorDiv(ex.Message);
            }
        }

        protected void btnEmailWorkOrder_Click(object sender, EventArgs e)
        {
            try
            {
                WorkOrderDocument wod = new WorkOrderDocument(_workOrderId);
                var report = wod.Generate();

                SmtpClient smtp = new SmtpClient(ConfigurationManager.AppSettings["EmailServer"]);
                smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailUsername"], ConfigurationManager.AppSettings["EmailPassword"], ConfigurationManager.AppSettings["EmailDomain"]);

                var mail = new MailMessage("renuoil@inviewlabs.com", ddlEmailWorkOrder.SelectedValue, "RenuOil Work Order", "Please find the attached Work Order");

                using (var memStrm = new MemoryStream())
                {
                    report.Publish(memStrm, Siberix.Report.FileFormat.PDF);
                    memStrm.Seek(0, SeekOrigin.Begin);
                    mail.Attachments.Add(new Attachment(memStrm, "WorkOrder" + _workOrderId + ".pdf", "application/pdf"));
                    smtp.Send(mail);
                }
                messages.AddSuccessDiv("Email has been sent.");
            }
            catch (Exception ex)
            {
                messages.AddErrorDiv(ex.GetFullMessage());
            }
        }

        protected void lbPrevious_OnClick(object sender, EventArgs e)
        {
            try
            {
                // Find the most recent that has same service type and account
                WorkOrderCollection coll = new WorkOrderCollection();
                coll.GetMulti(new PredicateExpression(WorkOrderFields.ServiceTypeId == _workOrder.ServiceTypeId & WorkOrderFields.AccountId == _workOrder.AccountId), 1, new SortExpression(WorkOrderFields.AppointmentDate | SortOperator.Descending));
                if (coll.Count == 1)
                {
                    var wod = new WorkOrderDocument(coll[0].WorkOrderId);
                    var report = wod.Generate();
                    publishReportForWeb(report);
                }
                else
                {
                    messages.AddNoticeDiv("No previous work order found.");
                }
            }
            catch (Exception ex)
            {
                messages.AddErrorDiv(ex.Message);
            }
        }

        public void publishReportForWeb(Siberix.Report.Report Report)
        {
            try
            {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                System.Web.HttpResponse response = context.Response;
                response.Clear();

                //PDF
                //response.ContentType = "application/pdf";
                //response.AddHeader("content-disposition", "attachment; filename=workOrder-" + string.Format("{0}-{1}.pdf", DateTime.Now.ToString("MMddyy"), sm.AuthenticatedUser.UserId.ToString()));

                //Report.Publish(response.OutputStream, Siberix.Report.FileFormat.PDF);
                //HttpContext.Current.ApplicationInstance.CompleteRequest();


                MemoryStream ms = new MemoryStream();
                Report.Publish(ms, Siberix.Report.FileFormat.PDF);
                ms.Seek(0, SeekOrigin.Begin);
                response.Clear();
                response.ContentType = "application/pdf";
                response.AddHeader("content-disposition", "attachment; filename=workOrder-" + string.Format("{0}-{1}.pdf", DateTime.Now.ToString("MMddyy"), sm.AuthenticatedUser.UserId.ToString()));
                response.AddHeader("Content-Length", ms.Length.ToString());
                ms.WriteTo(response.OutputStream);
                if (response.IsClientConnected)
                {
                    response.Flush();
                }

                response.Close();
            }
            catch (Exception ex)
            {
                messages.AddErrorDiv(ex.Message);
            }
        }

        private void populate()
        {
            if (!IsPostBack)
            {
                foreach (var user in _db.User.Where(u => u.EmailAddress != null && u.IsActive).OrderBy(u => u.FirstName).ThenBy(u => u.LastName))
                {
                    ddlEmailWorkOrder.Items.Add(new ListItem(user.FirstName + " " + user.LastName, user.EmailAddress));
                }
            }

            if (_workOrderId == 0)
            {
                workOrderTitle.InnerText = "Add New Work Order";
                rdDateWorkOrderDate.SelectedDate = DateTime.Today.Date;
                //instructions.Visible = true;
                switch (_workOrder.ServiceTypeId)
                {
                    case (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly:
                        populateAssetReclamationAccount();
                        break;
                    case (int)ServiceTypeEntity.ServiceTypes.RecycleOnly:
                        populateRecycleAccount();
                        break;
                    case (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly:
                        populateOilFiltrationAccount();
                        break;
                }
            }
            else
            {
                workOrderTitle.InnerText = "Edit Work Order";
                //instructions.Visible = false;

                ddlWorkOrderType.SelectedValue = _workOrder.ServiceTypeId.ToString();
                ddlWorkOrderType.Enabled = false;
                if (_workOrder.TechnicianId != null)
                    ddlTechnician.SelectedValue = _workOrder.TechnicianId.ToString();
                btnSaveWorkOrder.Visible = true;
                btnCancel.Visible = true;
                rdDateWorkOrderDate.SelectedDate = _workOrder.AppointmentDate.Date;
                rdTimeApptTime.SelectedDate = _workOrder.AppointmentTime;
                txtNotes.Text = _workOrder.Notes;
                txtUncategorizedItems.Text = _workOrder.WorkOrderServiceLocation.First().UncategorizedItems != null ? _workOrder.WorkOrderServiceLocation.First().UncategorizedItems : "";

                switch (_workOrder.ServiceTypeId)
                {
                    case (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly:
                        populateAssetReclamationAccount();
                        break;
                    case (int)ServiceTypeEntity.ServiceTypes.RecycleOnly:
                        populateRecycleAccount();
                        break;
                    case (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly:
                        populateOilFiltrationAccount();
                        break;
                }

                ddlAccount.Enabled = false;
                // use impersonation to view signature
                string username = ConfigurationManager.AppSettings["ImpersonatorUsername"];
                string password = ConfigurationManager.AppSettings["ImpersonatorPassword"];
                string domain = ConfigurationManager.AppSettings["ImpersonatorDomain"];
                string fileNameWithPath = Path.Combine(SettingsUtility.GetSetting("SignatureFilePath"), "signature_" + _workOrder.WorkOrderId.ToString() + ".png");

                using (new Impersonator(username, domain, password))
                {
                    if (File.Exists(fileNameWithPath))
                    {
                        imgSignature.Src = "/WorkOrderSignature/" + "signature_" + _workOrder.WorkOrderId.ToString() + ".png";
                        imgSignature.Visible = true;
                        lblSignature.Visible = true;
                    }
                }

                if (_workOrder.TechnicianId != null)
                {
                    ddlTechnician.SelectedValue = _workOrder.TechnicianId.Value.ToString();
                }
            }
        }

        private void populateOilFiltrationAccount()
        {
            var accounts = (from a in _db.Account
                            join sl in _db.ServiceLocation on a.AccountId equals sl.AccountId
                            where sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                            && a.IsActive == true
                            orderby a.Name
                            select a).ToList();
            ddlAccount.Bind(accounts, "Name", "AccountId");
            ddlAccount.SelectedValue = _workOrder.AccountId.ToString();

            divFryerAccount.Visible = true;
            divAssetReclamationAccount.Visible = false;
            divRecycle.Visible = false;
            divSelectDock.Visible = false;

            _serviceLocations = (from sl in _db.ServiceLocation
                                 where sl.AccountId == _workOrder.AccountId
                                 && sl.IsActive == true
                                 && sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                                 orderby sl.Ordinal
                                 select sl).ToList();
            rdServiceLocationsGrid.DataSource = _serviceLocations;
            rdServiceLocationsGrid.DataBind();
        }

        private void populateAssetReclamationAccount()
        {
            var accounts = (from a in _db.Account
                            join sl in _db.ServiceLocation on a.AccountId equals sl.AccountId
                            where sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                            && a.IsActive == true
                            orderby a.Name
                            select a).ToList();
            ddlAccount.Bind(accounts, "Name", "AccountId");
            ddlAccount.SelectedValue = _workOrder.AccountId.ToString();

            divFryerAccount.Visible = false;
            divAssetReclamationAccount.Visible = true;
            divRecycle.Visible = false;

            var docks = _db.ServiceLocation.Where(a => a.AccountId == _workOrder.AccountId && a.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly).ToList();
            ddlDocks.Enabled = false;
            ddlDocks.Bind(docks, "Name", "ServiceLocationId");
            if (_workOrder.WorkOrderId != 0)
                ddlDocks.SelectedValue = _workOrder.ServiceTypeId.ToString();

            var assetCategories = from ac in _db.AssetCategory
                                  orderby ac.Name
                                  select new
                                  {
                                      AssetCategoryId = ac.AssetCategoryId,
                                      Name = ac.Name.ToUpper()
                                  };

            rdAssetTypeGrid.DataSource = assetCategories;
            rdAssetTypeGrid.DataBind();
        }

        private void populateRecycleAccount()
        {
            var accounts = (from a in _db.Account
                            join sl in _db.ServiceLocation on a.AccountId equals sl.AccountId
                            where sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                            && a.IsActive == true
                            orderby a.Name
                            select a).ToList();
            ddlAccount.Bind(accounts, "Name", "AccountId");
            ddlAccount.SelectedValue = _workOrder.AccountId.ToString();

            // populate recycle types
            var recycleTypes = (from a in _db.Account
                                join sl in _db.ServiceLocation on a.AccountId equals sl.AccountId
                                join slrt in _db.ServiceLocationRecycleType on sl.ServiceLocationId equals slrt.ServiceLocationId
                                join rt in _db.RecycleType on slrt.RecycleTypeId equals rt.RecycleTypeId
                                where sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                                && a.IsActive == true
                                orderby a.Name
                                select rt).ToList();

            var docks = _db.ServiceLocation.Where(a => a.AccountId == _workOrder.AccountId && a.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly).ToList();
            ddlDocks.Enabled = false;
            ddlDocks.Bind(docks, "Name", "ServiceLocationId");
            if (_workOrder.WorkOrderId != 0)
                ddlDocks.SelectedValue = _workOrder.ServiceTypeId.ToString();


            ddlRecycleType.Bind(recycleTypes, "Name", "RecycleTypeId");

            divFryerAccount.Visible = false;
            divAssetReclamationAccount.Visible = false;
            divRecycle.Visible = true;

            var actionsList = (from wo in _db.WorkOrder
                               join wsl in _db.WorkOrderServiceLocation on wo.WorkOrderId equals wsl.WorkOrderId
                               join rs in _db.RecycleService on wsl.WorkOrderServiceLocationId equals rs.WorkOrderServiceLocationId
                               join rsa in _db.RecycleServiceAction on rs.RecycleServiceId equals rsa.RecycleServiceId
                               where wo.WorkOrderId == _workOrder.WorkOrderId && wo.ServiceTypeId == 3
                               select rsa).Distinct();

            rptActionListing.Bind(actionsList);

            var totalList = (from wo in _db.WorkOrder
                             join wsl in _db.WorkOrderServiceLocation on wo.WorkOrderId equals wsl.WorkOrderId
                             join rs in _db.RecycleService on wsl.WorkOrderServiceLocationId equals rs.WorkOrderServiceLocationId
                             join rsa in _db.RecycleServiceAction on rs.RecycleServiceId equals rsa.RecycleServiceId
                             where wo.WorkOrderId == _workOrder.WorkOrderId && wo.ServiceTypeId == 3
                             group rsa by rsa.ActionType into g
                             select //rsa).ToList();
                             new
                             {
                                 Action = g.Key == "O" ? "Observed" : g.Key == "A" ? "Actual" : g.Key == "D" ? "Facility Drop" : g.Key == "P" ? "Picked Up" : "Unknown",
                                 NumberOfBags = g.Sum(p => p.NumberOfBags),
                                 NumberOfBales = g.Sum(p => p.NumberOfBales),
                                 WeightOfBags = g.Sum(p => p.BagsWeight),
                                 WeightOfBales = g.Sum(p => p.BalesWeight)
                             }).ToList();


            rptTotals.Bind(totalList);

        }

        protected void rptActionListing_OnItemCommand(object sender, RepeaterCommandEventArgs e)
        {

            int recActId = Convert.ToInt32(e.CommandArgument.ToString());
            RecycleServiceActionEntity currentAct = new RecycleServiceActionEntity(recActId);
            currentAct = (RecycleServiceActionEntity)e.Item.DataItem;
            currentAct = _db.RecycleServiceAction.FirstOrDefault(h => h.RecycleServiceActionId == recActId);

            switch (e.CommandName)
            {

                case "Edit":
                    infoAction.Visible = true;
                    rdpActionDate.SelectedDate = currentAct.ActionTime; //new DateTime(currentAct.ActionTime.Year,currentAct.ActionTime.Month,currentAct.ActionTime.Day);
                    rtpActionTime.SelectedDate = currentAct.ActionTime;
                    txtNoBags.Text = currentAct.NumberOfBags.ToString();
                    txtNoBales.Text = currentAct.NumberOfBales.ToString();
                    txtWtBag.Text = currentAct.BagsWeight.ToString();
                    txtWtBale.Text = currentAct.BalesWeight.ToString();
                    string recType = currentAct.RecycleType.Description;
                    string recId = currentAct.RecycleType.RecycleTypeId.ToString();
                    ddlRecycleType.SelectedIndex = ddlRecycleType.Items.IndexOf(ddlRecycleType.Items.FindByValue(recId)); ;
                    string actType = currentAct.ActionType;
                    sm.RecActId = currentAct.RecycleServiceActionId;
                    if (actType.Equals("O"))
                        ddlActionType.SelectedIndex = ddlActionType.Items.IndexOf(ddlActionType.Items.FindByValue("O"));
                    else if (actType.Equals("A"))
                        ddlActionType.SelectedIndex = ddlActionType.Items.IndexOf(ddlActionType.Items.FindByValue("A"));
                    else if (actType.Equals("P"))
                        ddlActionType.SelectedIndex = ddlActionType.Items.IndexOf(ddlActionType.Items.FindByValue("P"));
                    else
                        ddlActionType.SelectedIndex = ddlActionType.Items.IndexOf(ddlActionType.Items.FindByValue("D"));

                    break;

            }

        }

        private bool validate()
        {
            if (rdDateWorkOrderDate.SelectedDate == null)
            {
                messages.Add(HtmlHelper.Div("error", "You must enter a date."));
                return false;
            }

            if (ddlAccount.SelectedValue == "")
            {
                messages.Add(HtmlHelper.Div("error", "You must select an account."));
                return false;
            }

            if (ddlTechnician.SelectedValue == "")
            {
                messages.Add(HtmlHelper.Div("error", "You must select a technician."));
                return false;
            }

            // check existing work order
            var existing = (from wo in _db.WorkOrder
                            where wo.AppointmentDate == rdDateWorkOrderDate.SelectedDate.Value.Date
                            && wo.AccountId == Convert.ToInt32(ddlAccount.SelectedValue)
                            select wo).ToList();

            //if (existing.Count() > 0)
            //{
            //    messages.Add(HtmlHelper.Div("warning", "There is already a work order for this account and date.  Do you still want to save this work order?"));
            //    LinkButton lnkBtnYes = new LinkButton();
            //    lnkBtnYes.Text = "Yes";
            //    lnkBtnYes.CommandName = "Save";
            //    lnkBtnYes.CommandArgument = "Yes";
            //    lnkBtnYes.Command += new CommandEventHandler(btnSaveWarning);

            //    LinkButton lnkBtnNo = new LinkButton();
            //    lnkBtnNo.Text = "No";
            //    lnkBtnNo.CommandName = "Save";
            //    lnkBtnNo.CommandArgument = "No";
            //    lnkBtnNo.Command += new CommandEventHandler(btnSaveWarning);

            //    messages.Controls.Add(HtmlHelper.Div("warning", lnkBtnYes));
            //    messages.Add(HtmlHelper.Div("warning", lnkBtnNo));


            //    return false;
            //}

            // P-2803 - require every restaurant to be answered
            foreach (GridDataItem item in rdServiceLocationsGrid.Items)
            {
                GridNestedViewItem detailView = (GridNestedViewItem)item.ChildItem;

                if (detailView != null)
                {
                    GridTableView tableView = detailView.NestedTableViews.First();
                    CheckBox chkSelectServiceLocation = item.FindControl("chkSelectServiceLocation") as CheckBox;

                    if (chkSelectServiceLocation != null)
                    {
                        if (chkSelectServiceLocation.Checked)
                        {
                            foreach (GridDataItem fryerItem in tableView.Items)
                            {
                                Hashtable itemValues = new Hashtable();
                                fryerItem.ExtractValues(itemValues);
                                int deepFryerId = Convert.ToInt32(itemValues["DeepFryerId"].ToString());

                                RadioButton rdBtnFilter = fryerItem.FindControl("rdBtnFilter") as RadioButton;
                                RadioButton rdBtnDiscard = fryerItem.FindControl("rdBtnDiscard") as RadioButton;
                                RadioButton rdBtnClean = fryerItem.FindControl("rdBtnClean") as RadioButton;
                                RadioButton rdBtnRelocate = fryerItem.FindControl("rdBtnRelocate") as RadioButton;
                                RadioButton rdBtnNoService = fryerItem.FindControl("rdBtnNoService") as RadioButton;

                                if (!rdBtnFilter.Checked && !rdBtnDiscard.Checked && !rdBtnClean.Checked && !rdBtnRelocate.Checked && !rdBtnNoService.Checked)
                                {
                                    messages.AddErrorDiv("All restaurants must be answered to save.");
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;


        }

        //protected void showPreviousData()
        //{
        //    ServiceTypeEntity sl2 = new ServiceTypeEntity(_workOrder.ServiceTypeId);
        //    if (sl2.ServiceTypeId != 1)
        //    {
        //        var workOrderServiceLocation = _workOrder.WorkOrderServiceLocation.First();
        //        var recycleService = workOrderServiceLocation.RecycleService.First();

        //        var p = (from rscl in _db.RecycleServiceChangeLog
        //                 where rscl.RecycleServiceId == recycleService.RecycleServiceId
        //                 orderby rscl.ChangeDate descending
        //                 select rscl).Take(2).ToList();

        //        if (p.Count() > 1)
        //        {
        //            RecycleServiceChangeLogEntity rscle = p[1];
        //            lblPrevNumberOfBags.Text += "\t\t" + rscle.NumberOfBags != null ? rscle.NumberOfBags.ToString() : "";
        //            lblPrevNumberOfBales.Text += "\t\t" + rscle.NumberOfBales != null ? rscle.NumberOfBales.ToString() : "";
        //            lblPrevBagsWeight.Text += "\t\t" + rscle.BagsWeight != null ? rscle.BagsWeight.ToString() : "";
        //            lblPrevBalesWeight.Text += "\t\t" + rscle.BalesWeight != null ? rscle.BalesWeight.ToString() : "";

        //            string name = "";
        //            if (rscle.EnteredByEmployeeId != null)
        //                name = rscle.Employee.FirstName + " " + rscle.Employee.LastName;
        //            else if (rscle.EnteredByUserId != null)
        //                name = rscle.User.FirstName + " " + rscle.User.LastName;

        //            if (name.Length > 0)
        //                name += " at " + rscle.ChangeDate.ToString();
        //            else
        //                name = "Date:  " + rscle.ChangeDate.ToString();

        //            lblPrevEnteredBy.Text += "\t\t" + name;
        //            previousValues.Visible = true;
        //        }
        //        else
        //            previousValues.Visible = false;
        //    }
        //}


        #endregion

        #region Control Events
        protected void menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value == "AssetTypes")
                multiView.ActiveViewIndex = 0;
            else if (e.Item.Value == "Recycling")
                multiView.ActiveViewIndex = 1;
        }

        protected void ddlAccount_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAccount.SelectedValue != "")
            {
                int acctId = Convert.ToInt32(ddlAccount.SelectedValue);
                _account = new AccountEntity(acctId);

                messages.Controls.Clear();

                if (!checkForExistingWorkOrder())
                {
                    return;
                }

                _workOrder.Account = _account;
                var docks = _db.ServiceLocation.Where(a => a.AccountId == acctId && a.ServiceTypeId == Convert.ToInt32(ddlWorkOrderType.SelectedValue)).ToList();
                docks.Add(new ServiceLocationEntity() { Name = "" });
                ddlDocks.Bind(docks, "Name", "ServiceLocationId");
                _serviceLocations = docks.ToList();

                if (Convert.ToInt32(ddlWorkOrderType.SelectedValue) == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly)
                {
                    divFryerAccount.Visible = true;
                    divAssetReclamationAccount.Visible = false;
                    divRecycle.Visible = false;
                    populateOilFiltrationAccount();
                }
            }
            else
            {
                _account = null;
                _workOrder.Account = null;
            }

            btnSaveWorkOrder.Visible = true;
            btnCancel.Visible = true;
            //instructions.Visible = false;
        }

        private bool checkForExistingWorkOrder()
        {
            try
            {

                var serviceType = Convert.ToInt32(ddlWorkOrderType.SelectedValue);
                var accountId = Convert.ToInt32(ddlAccount.SelectedValue);
                var account = new AccountEntity(accountId);
                var date = rdDateWorkOrderDate.SelectedDate.Value;

                var workOrder = from wo in _db.WorkOrder
                                where wo.ServiceTypeId == serviceType && wo.AccountId == accountId && wo.AppointmentDate == date
                                select wo.WorkOrderId;
                var newId = workOrder.FirstOrDefault();
                if (newId > 0)
                {
                    messages.AddErrorDiv(string.Format("There is already a work order for {0} on {1}", account.Name, date));
                    return false;
                }

                // Check to see if there was a missed day.
                // Start with yesterday, and work backwards
                var dayToCheck = date.AddDays(-1);
                var prev = dayToCheck.AddDays(-1);

                var orderExists = (from wo in _db.WorkOrder
                                   where wo.AccountId == account.AccountId && wo.AppointmentDate <= dayToCheck
                                       && wo.AppointmentDate >= prev && wo.ServiceTypeId == serviceType
                                   select wo).Count();

                if (orderExists == 0)
                {
                    messages.AddInfoDiv(string.Format("There is no work order for {0} in the previous two days", account.Name));
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return true;
        }

        protected void ddlDocks_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDocks.SelectedValue != "")
            {
                divFryerAccount.Visible = false;
                divAssetReclamationAccount.Visible = false;
                divRecycle.Visible = false;

                int acctId = Convert.ToInt32(ddlAccount.SelectedValue);
                _account = new AccountEntity(acctId);

                _workOrder.Account = _account;

                _serviceLocations = (from sl in _db.ServiceLocation
                                     where sl.AccountId == _account.AccountId && sl.ServiceLocationId == Convert.ToInt32(ddlDocks.SelectedValue)
                                     orderby sl.Name
                                     select sl).ToList();


                ServiceLocationEntity slSelected = new ServiceLocationEntity(Convert.ToInt32(_serviceLocations.First().ServiceLocationId));
                _serviceLocations.Clear();
                _serviceLocations.Add(slSelected);

                if (Convert.ToInt32(ddlWorkOrderType.SelectedValue) == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly)
                {
                    //divFryerAccount.Visible = false;
                    divAssetReclamationAccount.Visible = true;

                    populateAssetReclamationAccount();
                }
                if (Convert.ToInt32(ddlWorkOrderType.SelectedValue) == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly)
                {
                    //divFryerAccount.Visible = false;
                    //divAssetReclamationAccount.Visible = true;
                    divRecycle.Visible = true;

                    populateRecycleAccount();
                }

            }
            else
            {
                _account = null;
                _workOrder.Account = null;
            }

            btnSaveWorkOrder.Visible = true;
            btnCancel.Visible = true;
        }

        protected void ddlWorkOrderType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlWorkOrderType.SelectedValue != "")
            {
                messages.Controls.Clear();

                int workOrderType = Convert.ToInt32(ddlWorkOrderType.SelectedValue);

                if (!checkForExistingWorkOrder())
                {
                    return;
                }

                // populate accounts based on service location's service type
                var accounts = (from a in _db.Account
                                join sl in _db.ServiceLocation on a.AccountId equals sl.AccountId
                                where sl.ServiceTypeId == workOrderType
                                orderby a.Name
                                select a).ToList();

                ddlAccount.Items.Clear();
                ListItem li = new ListItem("", "");
                ddlAccount.Items.Add(li);

                foreach (AccountEntity ae in accounts)
                {
                    li = new ListItem(ae.Name, ae.AccountId.ToString());
                    ddlAccount.Items.Add(li);
                }
                divSelectDock.Visible = Convert.ToInt32(ddlWorkOrderType.SelectedValue) != (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly;
            }
            else
            {
                ddlAccount.Items.Clear();
                ListItem blank = new ListItem("", "");
                ddlAccount.Items.Add(blank);
                _account = null;
                _workOrder.Account = null;
                divFryerAccount.Visible = false;
                divAssetReclamationAccount.Visible = false;
                divRecycle.Visible = false;
            }

            btnSaveWorkOrder.Visible = true;
            btnCancel.Visible = true;
        }

        protected void radDatePicker_OnSelectedDateChanged(object sender, EventArgs e)
        {

            messages.Controls.Clear();

            if (!checkForExistingWorkOrder())
            {
                return;
            }
            int acctId = Convert.ToInt32(ddlAccount.SelectedValue);
            _account = new AccountEntity(acctId);

            _workOrder.Account = _account;
            var docks = _db.ServiceLocation.Where(a => a.AccountId == _account.AccountId && a.ServiceTypeId == Convert.ToInt32(ddlWorkOrderType.SelectedValue)).ToList();
            docks.Add(new ServiceLocationEntity() { Name = "" });
            ddlDocks.Bind(docks, "Name", "ServiceLocationId");
            _serviceLocations = docks.ToList();

            if (Convert.ToInt32(ddlWorkOrderType.SelectedValue) == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly)
            {
                divFryerAccount.Visible = true;
                divAssetReclamationAccount.Visible = false;
                divRecycle.Visible = false;
                populateOilFiltrationAccount();
            }
        }

        protected void btnSaveWarning(object sender, CommandEventArgs e)
        {
            if (e.CommandArgument.ToString() == "Yes")
                btnSaveWorkOrder_Click(sender, e);
            else
                btnCancel_Click(sender, e);
        }

        protected void btnSaveWorkOrder_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                _account = new AccountEntity(Convert.ToInt32(ddlAccount.SelectedValue));

                WorkOrder workOrder = null;
                bool newSave = false;

                if (_workOrderId == 0)
                {
                    workOrder = new WorkOrder();
                    newSave = true;
                }
                else
                    workOrder = new WorkOrder(_workOrderId);

                workOrder.AppointmentDate = rdDateWorkOrderDate.SelectedDate.Value;
                if (rdTimeApptTime.SelectedDate != null)
                {
                    workOrder.AppointmentTime = rdTimeApptTime.SelectedDate.Value;
                }

                workOrder.Account = _account;
                //workOrder.IsComplete = chkCompleted.Checked;
                workOrder.Notes = txtNotes.Text.Trim().Length > 0 ? txtNotes.Text.Trim() : null;
                workOrder.TechnicianId = Convert.ToInt32(ddlTechnician.SelectedValue);

                int serviceTypeId = Convert.ToInt32(ddlWorkOrderType.SelectedValue);
                if (serviceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly)
                {
                    List<DeepFryerEntity> fryers = new List<DeepFryerEntity>();

                    workOrder.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly;

                    foreach (GridDataItem item in rdServiceLocationsGrid.Items)
                    {
                        GridNestedViewItem detailView = (GridNestedViewItem)item.ChildItem;

                        if (detailView != null)
                        {
                            Hashtable serviceLocationValues = new Hashtable();
                            item.ExtractValues(serviceLocationValues);
                            int serviceLocationId = Convert.ToInt32(serviceLocationValues["ServiceLocationId"].ToString());

                            GridTableView tableView = detailView.NestedTableViews.First();
                            CheckBox chkSelectServiceLocation = item.FindControl("chkSelectServiceLocation") as CheckBox;
                            TextBox txtServiceLocationNotes = item.FindControl("txtServiceLocationNotes") as TextBox;

                            if (chkSelectServiceLocation != null)
                            {
                                if (chkSelectServiceLocation.Checked)
                                {
                                    WorkOrderServiceLocationEntity wosl = workOrder.AddServiceLocation(serviceLocationId, txtServiceLocationNotes.Text);

                                    foreach (GridDataItem fryerItem in tableView.Items)
                                    {
                                        Hashtable itemValues = new Hashtable();
                                        fryerItem.ExtractValues(itemValues);
                                        int deepFryerId = Convert.ToInt32(itemValues["DeepFryerId"].ToString());

                                        RadioButton rdBtnFilter = fryerItem.FindControl("rdBtnFilter") as RadioButton;
                                        RadioButton rdBtnDiscard = fryerItem.FindControl("rdBtnDiscard") as RadioButton;
                                        RadioButton rdBtnClean = fryerItem.FindControl("rdBtnClean") as RadioButton;
                                        RadioButton rdBtnRelocate = fryerItem.FindControl("rdBtnRelocate") as RadioButton;
                                        RadioButton rdBtnNoService = fryerItem.FindControl("rdBtnNoService") as RadioButton;
                                        //TextBox txtRelocateTo = fryerItem.FindControl("txtRelocateTo") as TextBox;
                                        //DropDownList ddlEmployees = fryerItem.FindControl("ddlEmployees") as DropDownList;
                                        //DropDownList ddlRelocateToServiceLocation = fryerItem.FindControl("ddlRelocateToServiceLocation") as DropDownList;

                                        if (rdBtnFilter != null)
                                        {
                                            int employeeId = 0;
                                            int relocateToServiceLocationId = 0;

                                            //if (ddlEmployees.SelectedValue != "")
                                            employeeId = Convert.ToInt32(ddlTechnician.SelectedValue);

                                            //if (ddlRelocateToServiceLocation.SelectedValue != "")
                                            //    relocateToServiceLocationId = Convert.ToInt32(ddlRelocateToServiceLocation.SelectedValue);

                                            workOrder.AddFryerService(wosl, deepFryerId, 0, rdBtnFilter.Checked, rdBtnClean.Checked, rdBtnDiscard.Checked, rdBtnNoService.Checked, rdBtnRelocate.Checked, relocateToServiceLocationId, "", employeeId);
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (GridDataItem fryerItem in tableView.Items)
                                    {
                                        Hashtable itemValues = new Hashtable();
                                        fryerItem.ExtractValues(itemValues);
                                        int deepFryerId = Convert.ToInt32(itemValues["DeepFryerId"].ToString());

                                        workOrder.RemoveFryerService(deepFryerId, 0);
                                    }

                                    workOrder.RemoveWorkOrderServiceLocationByServiceLocationId(serviceLocationId);
                                }
                            }
                        }
                    }
                }
                else if (serviceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly)
                {
                    workOrder.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly;
                    WorkOrderServiceLocationEntity wosl = workOrder.AddServiceLocation(Convert.ToInt32(ddlDocks.SelectedValue), txtNotes.Text);
                    wosl.UncategorizedItems = txtUncategorizedItems.Text.Length > 0 ? txtUncategorizedItems.Text.Trim() : null;

                    foreach (GridDataItem item in rdAssetTypeGrid.Items)
                    {
                        GridNestedViewItem detailView = (GridNestedViewItem)item.ChildItem;

                        if (detailView != null)
                        {
                            GridTableView tableView = detailView.NestedTableViews.First();
                            foreach (GridDataItem serviceLocationAssetTypeItem in tableView.Items)
                            {
                                Hashtable slatItemValues = new Hashtable();
                                serviceLocationAssetTypeItem.ExtractValues(slatItemValues);

                                int serviceLocationAssetTypeId = Convert.ToInt32(slatItemValues["ServiceLocationAssetTypeId"].ToString());

                                TextBox txtQuantity = serviceLocationAssetTypeItem.FindControl("txtQuantity") as TextBox;

                                int quantity = 0;

                                try
                                {
                                    if (txtQuantity.Text.Length > 0)
                                        quantity = Convert.ToInt32(txtQuantity.Text);
                                }
                                catch
                                {
                                    // ignore
                                }
                                workOrder.AddServiceLocationAssetTypeQuantity(wosl, serviceLocationAssetTypeId, quantity);
                            }
                        }
                    }
                }
                else if (serviceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly)
                {
                    workOrder.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.RecycleOnly;
                    WorkOrderServiceLocationEntity wosl = workOrder.AddServiceLocation(Convert.ToInt32(ddlDocks.SelectedValue), txtNotes.Text);
                    var recycleService = workOrder.AddRecyclingService(wosl, 0, 0, 0, 0);
                    _recycleServiceId = recycleService.RecycleServiceId;


                }

                workOrder.Save();
                if (!newSave)
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=" + workOrder.WorkOrderId + "\");", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=" + workOrder.WorkOrderId + "&newsave=1" + "\");", true);
                }
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "redirect", "redirect(\"WorkOrders.aspx\");", true);
        }


        protected void btnopenAction_Click(object sender, EventArgs e)
        {
            infoAction.Visible = true;
            rdpActionDate.SelectedDate = DateTime.Today;
        }

        protected void btnCnclAction_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=" + _workOrderId + "\");", true);
        }

        protected void btnSaveAction_Click(object sender, EventArgs e)
        {
            if (_workOrderId != null)
            {
                int numberOfBags = 0;
                int numberOfBales = 0;
                decimal weightOfBags = 0;
                decimal weightOfBales = 0;
                if (Int32.TryParse(txtNoBags.Text, out numberOfBags) && Int32.TryParse(txtNoBales.Text, out numberOfBales) &&
                    Decimal.TryParse(txtWtBag.Text, out weightOfBags) && Decimal.TryParse(txtWtBale.Text, out weightOfBales))
                {
                    var actionDate = rdpActionDate.SelectedDate.Value.AddHours(rtpActionTime.SelectedDate.Value.Hour);
                    actionDate = actionDate.AddMinutes(rtpActionTime.SelectedDate.Value.Minute);

                    RecycleServiceActionEntity rsa = new RecycleServiceActionEntity();
                    if (sm.RecActId.HasValue)
                    {
                        rsa = new RecycleServiceActionEntity(sm.RecActId.Value);
                    }
                    rsa.ActionTime = actionDate;
                    rsa.ActionType = ddlActionType.SelectedValue;
                    rsa.BagsWeight = weightOfBags;
                    rsa.BalesWeight = weightOfBales;
                    rsa.NumberOfBags = numberOfBags;
                    rsa.NumberOfBales = numberOfBales;
                    rsa.LastChangedByUserId = sm.AuthenticatedUser.UserId;
                    if (!sm.RecActId.HasValue)
                    {
                        rsa.ActionUserId = sm.AuthenticatedUser.UserId;
                    }
                    // for recycling, there will only be one service locatio (= dock) per work order. so we can select the first one
                    // these are created when work orders are created
                    var recycleServiceId = (from wo in _db.WorkOrder
                                            join wsl in _db.WorkOrderServiceLocation on wo.WorkOrderId equals wsl.WorkOrderId
                                            join rs in _db.RecycleService on wsl.WorkOrderServiceLocationId equals rs.WorkOrderServiceLocationId
                                            where wo.WorkOrderId == _workOrder.WorkOrderId && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                                            select rs.RecycleServiceId).FirstOrDefault();
                    int dockId = Convert.ToInt32(ddlDocks.SelectedValue);
                    if (recycleServiceId == 0)
                    {
                        // for some reason, we didn't create one when we created the work order record...so create one now
                        var wosl = _db.WorkOrderServiceLocation.Where(w => w.WorkOrderId == _workOrderId && w.ServiceLocationId == dockId).FirstOrDefault();
                        if (wosl.WorkOrderServiceLocationId != 0)
                        {


                            RecycleServiceEntity recycleService = new RecycleServiceEntity(_recycleServiceId);
                            recycleService.WorkOrderServiceLocationId = wosl.WorkOrderServiceLocationId;
                            recycleService.NumberOfBags = numberOfBags;
                            recycleService.NumberOfBales = numberOfBales;
                            recycleService.BagsWeight = weightOfBags;
                            recycleService.BalesWeight = weightOfBales;
                            recycleService.Save();
                            recycleServiceId = recycleService.RecycleServiceId;
                        }
                        else
                        {
                            WorkOrderServiceLocationEntity newWosl = new WorkOrderServiceLocationEntity();
                            newWosl.WorkOrderId = _workOrderId;
                            newWosl.ServiceLocationId = Convert.ToInt32(dockId);
                            newWosl.Save();
                        }
                    }

                    rsa.RecycleTypeId = Convert.ToInt32(ddlRecycleType.SelectedValue);
                    rsa.RecycleServiceId = recycleServiceId;
                    rsa.Save();

                    sm.RecActId = null;
                    actionMessages.AddSuccessDiv("Action successfully recorded");
                    ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=" + _workOrderId + "\");", true);
                }
                else
                {
                    actionMessages.AddErrorDiv("Invalid action entry. Please check fields and try again.");
                }
            }
            else
            {
                actionMessages.AddErrorDiv("Please save work order before adding actions");
            }
        }
        #endregion

        #region RadGrid Events
        #region Fryers
        protected void rdServiceLocationsGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                if (e.Item.OwnerTableView.Name == "MasterView")
                {
                    ServiceLocationEntity serviceLocation = e.Item.DataItem as ServiceLocationEntity;
                    CheckBox chkSelectServiceLocation = e.Item.FindControl("chkSelectServiceLocation") as CheckBox;
                    TextBox txtServiceLocationNotes = e.Item.FindControl("txtServiceLocationNotes") as TextBox;
                    DropDownList ddlAssignAllTo = e.Item.FindControl("ddlAssignAllTo") as DropDownList;
                    HtmlGenericControl lblName = e.Item.FindControl("lblName") as HtmlGenericControl;
                    HtmlGenericControl serviceAllByLabel = e.Item.FindControl("serviceAllByLabel") as HtmlGenericControl;

                    //lblName.InnerText = serviceLocation.Name;
                    if (sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
                    {
                        ddlAssignAllTo.Visible = false;
                        txtServiceLocationNotes.Visible = false;
                        serviceAllByLabel.Visible = false;
                    }

                    if (chkSelectServiceLocation != null)
                    {
                        chkSelectServiceLocation.Text = serviceLocation.Name;
                        if (_workOrder.WorkOrderId > 0)
                        {
                            var workOrderServiceLocation = from wosl in _db.WorkOrderServiceLocation
                                                           where wosl.WorkOrderId == _workOrder.WorkOrderId
                                                           && wosl.ServiceLocationId == serviceLocation.ServiceLocationId
                                                           select wosl;

                            if (workOrderServiceLocation.Count() > 0)
                            {
                                chkSelectServiceLocation.Checked = true;
                                if (workOrderServiceLocation.First().Notes == "Enter notes here.")
                                    txtServiceLocationNotes.Text = "";
                                else
                                    txtServiceLocationNotes.Text = workOrderServiceLocation.First().Notes;
                            }
                            else
                                chkSelectServiceLocation.Checked = false;

                        }
                        else
                        {
                            chkSelectServiceLocation.Checked = true;
                        }
                    }

                    if (ddlAssignAllTo != null)
                    {
                        ddlAssignAllTo.Items.Add(new ListItem("", ""));

                        foreach (EmployeeEntity emp in _employees)
                        {
                            ListItem li = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlAssignAllTo.Items.Add(li);
                        }
                    }
                }
                else if (e.Item.OwnerTableView.Name == "FryersView")
                {
                    Label lblName = e.Item.FindControl("lblName") as Label;
                    DropDownList ddlEmployees = e.Item.FindControl("ddlEmployees") as DropDownList;
                    RadioButton rdBtnFilter = e.Item.FindControl("rdBtnFilter") as RadioButton;
                    RadioButton rdBtnDiscard = e.Item.FindControl("rdBtnDiscard") as RadioButton;
                    RadioButton rdBtnClean = e.Item.FindControl("rdBtnClean") as RadioButton;
                    RadioButton rdBtnNoService = e.Item.FindControl("rdBtnNoService") as RadioButton;
                    RadioButton rdBtnRelocate = e.Item.FindControl("rdBtnRelocate") as RadioButton;
                    DropDownList ddlRelocateToServiceLocation = e.Item.FindControl("ddlRelocateToServiceLocation") as DropDownList;
                    TextBox txtRelocateTo = e.Item.FindControl("txtRelocateTo") as TextBox;

                    if (ddlEmployees != null)
                    {
                        ddlEmployees.Items.Add(new ListItem("", ""));
                        foreach (EmployeeEntity emp in _employees)
                        {
                            ListItem li = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployees.Items.Add(li);
                        }
                    }

                    if (lblName != null)
                    {
                        DeepFryerEntity deepFryer = e.Item.DataItem as DeepFryerEntity;
                        lblName.Text = deepFryer.Name;
                        rdBtnFilter.Checked = false;
                        rdBtnDiscard.Checked = false;
                        rdBtnClean.Checked = false;
                        rdBtnNoService.Checked = false;
                        rdBtnRelocate.Checked = false;

                        if (ddlRelocateToServiceLocation != null)
                        {
                            ddlRelocateToServiceLocation.Items.Add(new ListItem("Choose Service Location", ""));
                            foreach (ServiceLocationEntity sle in _serviceLocations)
                            {
                                if (sle.ServiceLocationId != deepFryer.ServiceLocationId)
                                {
                                    ListItem li = new ListItem(sle.Name, sle.ServiceLocationId.ToString());
                                    ddlRelocateToServiceLocation.Items.Add(li);
                                }
                            }
                        }

                        if (_workOrder.WorkOrderId > 0)
                        {
                            var deepFryerServices = from dfs in _db.DeepFryerService
                                                    join wosl in _db.WorkOrderServiceLocation on dfs.WorkOrderServiceLocationId equals wosl.WorkOrderServiceLocationId
                                                    join df in _db.DeepFryer on dfs.DeepFryerId equals df.DeepFryerId
                                                    where dfs.DeepFryerId == deepFryer.DeepFryerId
                                                    && wosl.WorkOrderId == _workOrder.WorkOrderId
                                                    && wosl.ServiceLocationId == deepFryer.ServiceLocationId
                                                    select dfs;

                            if (deepFryerServices.Count() > 0)
                            {
                                DeepFryerServiceEntity deepFryerService = deepFryerServices.First();

                                lblName.Text = deepFryerService.DeepFryer.Name;
                                //ddlEmployees.SelectedValue = deepFryerService.Servicedby != null ? deepFryerService.Servicedby.Value.ToString() : "";
                                rdBtnFilter.Checked = deepFryerService.Filtered != null ? deepFryerService.Filtered.Value : false;
                                rdBtnDiscard.Checked = deepFryerService.Discarded != null ? deepFryerService.Discarded.Value : false;
                                rdBtnClean.Checked = deepFryerService.Cleaned != null ? deepFryerService.Cleaned.Value : false;
                                rdBtnNoService.Checked = deepFryerService.NoService != null ? deepFryerService.NoService.Value : false;
                                rdBtnRelocate.Checked = deepFryerService.Relocated != null ? deepFryerService.Relocated.Value : false;
                                //txtRelocateTo.Text = deepFryerService.RelocatedToOther != null ? deepFryerService.RelocatedToOther : "";
                                //ddlRelocateToServiceLocation.SelectedValue = deepFryerService.RelocatedToServiceLocationId != null ? deepFryerService.RelocatedToServiceLocationId.Value.ToString() : "";
                                //ddlEmployees.SelectedValue = deepFryerService.Servicedby != null ? deepFryerService.Servicedby.Value.ToString() : "";
                            }
                        }
                    }

                }
                else if (e.Item.OwnerTableView.Name == "NotesView")
                {

                }
            }
        }

        protected void rdServiceLocationsGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            //if (!e.IsFromDetailTable)
            //{
            //    var serviceLocations = from sl in _db.ServiceLocation
            //                           where sl.AccountId == _account.AccountId
            //                           orderby sl.Name
            //                           select sl;

            //    rdServiceLocationsGrid.DataSource = serviceLocations;

            //}
        }

        protected void rdServiceLocationsGrid_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
            Hashtable values = new Hashtable();
            dataItem.ExtractValues(values);

            int serviceLocationId = Convert.ToInt32(values["ServiceLocationId"].ToString());
            ServiceLocationEntity sle = new ServiceLocationEntity(serviceLocationId);

            if (_workOrder.WorkOrderId > 0)
            {
                var fryers = from df in _db.DeepFryer
                             where df.ServiceLocationId == sle.ServiceLocationId
                             orderby df.Name
                             select df;

                // Remove them if they are inactive and there is no action on them for this work order.
                var actions = from dfs in _db.DeepFryerService
                              where dfs.WorkOrderServiceLocation.WorkOrderId == _workOrderId && dfs.WorkOrderServiceLocation.ServiceLocationId == serviceLocationId
                              select dfs.DeepFryerId;



                e.DetailTableView.DataSource = fryers.Where(f => actions.Contains(f.DeepFryerId));
            }
            else
            {
                var fryers = from df in _db.DeepFryer
                             where df.ServiceLocationId == sle.ServiceLocationId && df.IsActive == true
                             orderby df.Name
                             select df;

                e.DetailTableView.DataSource = fryers;
            }
        }

        protected void chkSelectServiceLocation_OnCheckChanged(object sender, EventArgs e)
        {
            CheckBox chkbx = (CheckBox)sender;

            // mark all fryers checked if service location is checked
            GridDataItem dataItem = (GridDataItem)chkbx.Parent.Parent;
            GridNestedViewItem detailView = (GridNestedViewItem)dataItem.ChildItem;
            GridTableView tableView = detailView.NestedTableViews.First();

            foreach (GridDataItem item in tableView.Items)
            {
                CheckBox chkIncludeFryer = item.FindControl("chkIncludeFryer") as CheckBox;
                chkIncludeFryer.Checked = chkbx.Checked;
            }
        }

        protected void chkIncludeFryer_OnCheckChanged(object sender, EventArgs e)
        {
            CheckBox chkIncludeFryer = (CheckBox)sender;

            // we need to mark the service location checked if the fryer is checked
            GridDataItem dataItem = (GridDataItem)chkIncludeFryer.Parent.Parent;
            GridTableView tableView = (GridTableView)dataItem.Parent.Parent.Parent.Parent.Parent.Parent;
            GridTableCell tableCell = (GridTableCell)dataItem.Parent.Parent.Parent;
            GridNestedViewItem nestViewItem = (GridNestedViewItem)tableCell.Parent;
            GridDataItem parentItem = (GridDataItem)nestViewItem.ParentItem;

            CheckBox chkSelectServiceLocation = parentItem.FindControl("chkSelectServiceLocation") as CheckBox;

            if (chkSelectServiceLocation != null && chkIncludeFryer.Checked)
                chkSelectServiceLocation.Checked = true;
        }

        protected void ddlAssignAllTo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlAssignAllTo = (DropDownList)sender;

            // mark all fryers checked if service location is checked
            GridDataItem dataItem = (GridDataItem)ddlAssignAllTo.Parent.Parent;
            GridNestedViewItem detailView = (GridNestedViewItem)dataItem.ChildItem;
            GridTableView tableView = detailView.NestedTableViews.First();

            foreach (GridDataItem item in tableView.Items)
            {
                DropDownList ddlEmployees = item.FindControl("ddlEmployees") as DropDownList;
                ddlEmployees.SelectedValue = ddlAssignAllTo.SelectedValue;
            }
        }

        protected void ddlRelocateToServiceLocation_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlRelocateToServiceLocation = (DropDownList)sender;

            // mark all fryers checked if service location is checked
            GridDataItem dataItem = (GridDataItem)ddlRelocateToServiceLocation.Parent.Parent;
            RadioButton rdBtnRelocate = dataItem.FindControl("rdBtnRelocate") as RadioButton;
            if (ddlRelocateToServiceLocation.SelectedValue != "")
                rdBtnRelocate.Checked = true;
        }

        #endregion

        #region Asset Reclamation
        #region rdAssetTypeGrid
        protected void rdAssetTypeGrid_OnDataBinding(object source, EventArgs e)
        {

        }

        protected void rdAssetTypeGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            //var _serviceLocation = (from sl in _db.ServiceLocation
            //                        where sl.AccountId == _account.AccountId
            //                        select sl).Single();//


            var _serviceLocation = _db.WorkOrderServiceLocation.Where(s => s.WorkOrderId == _workOrderId).OrderByDescending(s => s.WorkOrderServiceLocationId).FirstOrDefault();
            if (e.Item is GridDataItem && _serviceLocation != null)
            {
                if (e.Item.OwnerTableView.Name == "AssetTypeView")
                {
                    ServiceLocationAssetTypeEntity serviceLocationAssetType = e.Item.DataItem as ServiceLocationAssetTypeEntity;
                    AssetReclamationServiceEntity arse = null;

                    Label lblName = e.Item.FindControl("lblName") as Label;
                    Label lblSpanishName = e.Item.FindControl("lblSpanishName") as Label;
                    Label lblPricePerUnit = e.Item.FindControl("lblPricePerUnit") as Label;
                    TextBox txtQuantity = e.Item.FindControl("txtQuantity") as TextBox;

                    if (lblName != null)
                    {
                        var assetreclamationService = from ars in _db.AssetReclamationService
                                                      // join wosl in _db.WorkOrderServiceLocation on ars.WorkOrderServiceLocationId equals wosl.WorkOrderServiceLocationId
                                                      join slat in _db.ServiceLocationAssetType on ars.ServiceLocationAssetTypeId equals slat.ServiceLocationAssetTypeId
                                                      // where wosl.WorkOrderId == _workOrder.WorkOrderId
                                                      where ars.WorkOrderServiceLocationId == _serviceLocation.WorkOrderServiceLocationId
                                                      && slat.ServiceLocationAssetTypeId == serviceLocationAssetType.ServiceLocationAssetTypeId
                                                      select ars;
                        if (assetreclamationService.Count() > 0)
                        {
                            arse = assetreclamationService.First();

                            lblName.Text = serviceLocationAssetType.AssetType.Name;
                            lblSpanishName.Text = serviceLocationAssetType.AssetType.SpanishLabel;
                            lblPricePerUnit.Text = serviceLocationAssetType.PricePerUnit.ToString("C");
                            txtQuantity.Text = arse.Quantity.ToString();
                        }
                        else
                        {
                            lblName.Text = serviceLocationAssetType.AssetType.Name;
                            lblSpanishName.Text = serviceLocationAssetType.AssetType.SpanishLabel;
                            lblPricePerUnit.Text = serviceLocationAssetType.PricePerUnit.ToString("C");
                            txtQuantity.Text = "";

                        }
                    }
                }
            }
        }

        protected void rdAssetTypeGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

        }

        protected void rdAssetTypeGrid_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
            Hashtable values = new Hashtable();
            dataItem.ExtractValues(values);

            int assetCategoryId = Convert.ToInt32(values["AssetCategoryId"].ToString());
            AssetCategoryEntity assetCategory = new AssetCategoryEntity(assetCategoryId);

            //var _serviceLocation = (from sl in _db.ServiceLocation
            //                        where sl.AccountId == _account.AccountId
            //                        select sl).Single();//
            var _serviceLocation = _db.WorkOrderServiceLocation.OrderByDescending(s => s.WorkOrderId == _workOrderId).FirstOrDefault();
            //var _serviceLocation = _serviceLocations.First();
            var serviceLocationAssetType = from slat in _db.ServiceLocationAssetType
                                           join at in _db.AssetType on slat.AssetTypeId equals at.AssetTypeId
                                           join ac in _db.AssetCategory on at.AssetCategoryId equals ac.AssetCategoryId
                                           where slat.ServiceLocationId == _serviceLocation.ServiceLocationId
                                           && ac.AssetCategoryId == assetCategory.AssetCategoryId
                                           select slat;

            //var assetTypes = from at in _db.AssetType
            //                 where at.AssetCategoryId == assetCategory.AssetCategoryId
            //                 orderby at.Name
            //                 select at;

            e.DetailTableView.DataSource = serviceLocationAssetType;

        }
        #endregion
        #endregion
        #endregion
    }
}