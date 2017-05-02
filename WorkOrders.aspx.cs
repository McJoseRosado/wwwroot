using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ReliantUtilityLibrary;

namespace RenuOil
{
    public partial class WorkOrders : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private bool _isCompanyUser = false;
        private List<UserAccountEntity> _userAccounts = new List<UserAccountEntity>();

        private SessionManager _sm
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
            if (!Page.IsPostBack)
            {
                rdFromDate.SelectedDate = DateTime.Now.AddDays(-7);
                rdToDate.SelectedDate = DateTime.Now;
                ddlAccount.Items.Add(new ListItem()
                {
                    Text = "All Accounts",
                    Value = ""
                });

                List<AccountEntity> accounts = _db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList();

                foreach (var account in accounts)
                {
                    ddlAccount.Items.Add(new ListItem()
                    {
                        Text = account.Name,
                        Value = account.AccountId.ToString()
                    });
                }

                multiView.ActiveViewIndex = 0;
            }

            if (_sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
            {
                _isCompanyUser = true;
                btnAddNewWorkOrder.Visible = false;
                _userAccounts = _sm.AuthenticatedUser.UserAccount.ToList();
            }

            populateLists();
        }

        #endregion

        #region Methods
        protected void populateLists()
        {
            List<WorkOrderEntity> oilWorkOrders = new List<WorkOrderEntity>();
            List<WorkOrderEntity> recyclingOrders = new List<WorkOrderEntity>();
            List<WorkOrderEntity> assetOrders = new List<WorkOrderEntity>();

            if (ddlAccount.SelectedValue == "")
            {
                var o = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                         && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                         orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                         select wo);

                var r = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                         && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                         orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                         select wo);

                var asset = (from wo in _db.WorkOrder
                             join a in _db.Account on wo.AccountId equals a.AccountId
                             where a.IsActive == true
                             && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                             && wo.IsActive == true
                             && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                             && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                             orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                             select wo);

                oilWorkOrders = o.ToList();
                recyclingOrders = r.ToList();
                assetOrders = asset.ToList();
            }
            else
            {
                int selectedAccountId = Convert.ToInt32(ddlAccount.SelectedValue);

                var o = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && a.AccountId == selectedAccountId
                         && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                         && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                         select wo);

                var r = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && a.AccountId == selectedAccountId
                         && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                         && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                         select wo);

                var asset = (from wo in _db.WorkOrder
                             join a in _db.Account on wo.AccountId equals a.AccountId
                             where a.IsActive == true
                             && a.AccountId == selectedAccountId
                             && wo.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                             && wo.IsActive == true
                             && wo.AppointmentDate >= rdFromDate.SelectedDate.Value
                             && wo.AppointmentDate <= rdToDate.SelectedDate.Value
                             orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                             select wo);

                oilWorkOrders = o.ToList();
                recyclingOrders = r.ToList();
                assetOrders = asset.ToList();
            }

            if (_isCompanyUser)
            {
                oilWorkOrders = (from wo in oilWorkOrders
                                 join ua in _userAccounts on wo.AccountId equals ua.AccountId
                                 select wo).ToList();

                recyclingOrders = (from wo in recyclingOrders
                                   join ua in _userAccounts on wo.AccountId equals ua.AccountId
                                   select wo).ToList();

                assetOrders = (from wo in assetOrders
                               join ua in _userAccounts on wo.AccountId equals ua.AccountId
                               select wo).ToList();
            }

            rptOilFiltrationWorkOrders.DataSource = oilWorkOrders;
            rptOilFiltrationWorkOrders.DataBind();

            rptRecyclingWorkOrders.DataSource = recyclingOrders;
            rptRecyclingWorkOrders.DataBind();

            rptAssetWorkOrders.DataSource = assetOrders;
            rptAssetWorkOrders.DataBind();
        }

        protected void changeToOilFiltrationView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 0;
            if (!lnkBtnOilFiltration.CssClass.Contains("selected"))
                lnkBtnOilFiltration.CssClass += " selected";
            lnkBtnRecycling.CssClass = lnkBtnRecycling.CssClass.Replace(" selected", "");
            lnkBtnAsset.CssClass = lnkBtnAsset.CssClass.Replace(" selected", "");
        }

        protected void changeToRecyclingView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 1;
            if (!lnkBtnRecycling.CssClass.Contains("selected"))
                lnkBtnRecycling.CssClass += " selected";
            lnkBtnOilFiltration.CssClass = lnkBtnOilFiltration.CssClass.Replace(" selected", "");
            lnkBtnAsset.CssClass = lnkBtnAsset.CssClass.Replace(" selected", "");
        }

        protected void changeToAssetView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 2;
            if (!lnkBtnAsset.CssClass.Contains("selected"))
                lnkBtnAsset.CssClass += " selected";
            lnkBtnRecycling.CssClass = lnkBtnRecycling.CssClass.Replace(" selected", "");
            lnkBtnOilFiltration.CssClass = lnkBtnOilFiltration.CssClass.Replace(" selected", "");
        }

        #endregion


        #region Control Events

        protected void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=0\");", true);    
        }

        protected void btnUpdateWorkOrderList_Click(object sender, EventArgs e)
        {
            populateLists();
        }

        #endregion

        #region Repeater Events

        #region Work Orders
        protected void rptWorkOrders_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                WorkOrderEntity workOrder = e.Item.DataItem as WorkOrderEntity;

                LinkButton lnkBtnEditWorkOrder = e.Item.FindControl("lnkBtnEditWorkOrder") as LinkButton;
                Label lblDate = e.Item.FindControl("lblDate") as Label;
                Label lblAssignedTo = e.Item.FindControl("lblAssignedTo") as Label;
                //Label lblIsComplete = e.Item.FindControl("lblIsComplete") as Label;
                Label lblDayOfWeek = e.Item.FindControl("lblDayOfWeek") as Label;

                lnkBtnEditWorkOrder.Text = workOrder.Account.Name;
                lblDate.Text = workOrder.AppointmentDate.ToShortDateString();
                lblDayOfWeek.Text = workOrder.AppointmentDate.DayOfWeek.ToString();
                //lblIsComplete.Text = workOrder.IsComplete.ToString();
            }
        }

        protected void rptWorkOrders_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            int workOrderId = Convert.ToInt32(e.CommandArgument.ToString());

            switch (e.CommandName)
            {
                case "Edit":
                    ScriptManager.RegisterStartupScript(UpdatePanel3, UpdatePanel3.GetType(), "redirect", "redirect(\"EditWorkOrder.aspx?id=" + e.CommandArgument.ToString() + "\");", true);   
                    break;

                case "Delete":
                    WorkOrderEntity workOrder = new WorkOrderEntity(workOrderId);
                    workOrder.IsActive = false;
                    workOrder.Save();

                    populateLists();
                    //var q = (from wo in _db.WorkOrder
                    //         join a in _db.Account on wo.AccountId equals a.AccountId
                    //         where a.IsActive == true
                    //         && wo.IsActive == true
                    //         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                    //         select wo);
                    ////if (!chkShowCompleted.Checked) q = q.Where(x => !x.IsComplete);
                    //var workOrders = q.ToList();

                    //rptOilFiltrationWorkOrders.DataSource = workOrders;
                    //rptOilFiltrationWorkOrders.DataBind();

                    break;

                default:
                    break;

            }
        }
        #endregion

        #endregion

    }
}
