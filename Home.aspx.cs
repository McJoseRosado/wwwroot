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

namespace RenuOil
{
    public partial class Home : System.Web.UI.Page
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (_sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.Loader_Driver)
            {
                oilFiltrationBox.Visible = false;
                oilFiltrationNoAccessBox.Visible = true;

                oilFiltrationBox.Visible = false;
                oilFiltrationNoAccessBox.Visible = true;

                assetBox.Visible = false;
                assetNoAccessBox.Visible = true;

                usersBox.Visible = false;
                usersNoAccessBox.Visible = true;

                schedulesBox.Visible = false;
                schedulesNoAccessBox.Visible = true;

                settingsBox.Visible = false;
                settingsNoAccessBox.Visible = true;

            }

            if (_sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.Manager)
            {
                usersBox.Visible = false;
                usersNoAccessBox.Visible = true;
            }

            if (_sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
            {
                mainView.Visible = false;
                companyView.Visible = true;
            }

        }

        #region Control Events
        protected void lnkBtnOilFiltrationAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("OilFiltrationAccounts.aspx");
        }

        protected void lnkBtnAssetReclamationAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssetReclamationAccounts.aspx");
        }

        #endregion

        #region OLD
        //#region Members
        //public Tabs CurrentTab { get; set; }
        //private LinqMetaData _db = new LinqMetaData();

        //public SessionManager sm
        //{
        //    get
        //    {
        //        if (Session["SessionManager"] == null)
        //        {
        //            Session["SessionManager"] = new SessionManager();
        //        }
        //        return (SessionManager)Session["SessionManager"];
        //    }
        //    set
        //    {
        //        Session["SessionManager"] = value;
        //    }
        //}

        //public enum Tabs
        //{
        //    Accounts = 0,
        //    Employees = 1,
        //    Users = 2,
        //    Appointments = 3,
        //    Administration = 4
        //}
        //#endregion

        //#region Page Events

        //protected void Page_Init(object sender, EventArgs e)
        //{
        //    if (sm.AuthenticatedUser == null)
        //        Response.Redirect("~/Login.aspx");

        //    int tab = 0;
        //    int.TryParse(Request.QueryString["tab"], out tab);
        //    switch ((Tabs)tab)
        //    {
        //        case Tabs.Appointments:
        //            mvTabDetails.SetActiveView(viewAppointments);
        //            CurrentTab = Tabs.Appointments;
        //            break;

        //        case Tabs.Accounts:
        //            mvTabDetails.SetActiveView(viewAccounts);
        //            CurrentTab = Tabs.Accounts;
        //            break;

        //        case Tabs.Employees:
        //            mvTabDetails.SetActiveView(viewEmployees);
        //            CurrentTab = Tabs.Employees;
        //            break;

        //        case Tabs.Users:
        //            mvTabDetails.SetActiveView(viewUsers);
        //            CurrentTab = Tabs.Users;
        //            break;

        //        case Tabs.Administration:
        //            mvTabDetails.SetActiveView(viewAdmin);
        //            CurrentTab = Tabs.Administration;
        //            break;

        //        default:
        //            mvTabDetails.SetActiveView(viewAppointments);
        //            CurrentTab = Tabs.Appointments;
        //            break;
        //    }
        //}

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    string hrefFormat = "~/Home.aspx?tab={0}";
        //    lnkAppointments.HRef = string.Format(hrefFormat, ((int)Tabs.Appointments).ToString());
        //    lnkAccounts.HRef = string.Format(hrefFormat, ((int)Tabs.Accounts).ToString());
        //    lnkEmployees.HRef = string.Format(hrefFormat, ((int)Tabs.Employees).ToString());
        //    lnkUsers.HRef = string.Format(hrefFormat, ((int)Tabs.Users).ToString());
        //    lnkAdministration.HRef = string.Format(hrefFormat, ((int)Tabs.Administration).ToString());
        //    //HtmlAnchor breadcrumb = Master.FindControl("lnkBreadcrumbs") as HtmlAnchor;
        //    //breadcrumb.HRef = "~/Home.aspx";
        //    //breadcrumb.InnerText = "Home";

        //    switch (CurrentTab)
        //    {
        //        case Tabs.Appointments:
        //            appointmentsTab.Attributes["class"] += " active";
        //            break;
        //        case Tabs.Accounts:
        //            acctsTab.Attributes["class"] += " active";
        //            break;
        //        case Tabs.Employees:
        //            employeesTab.Attributes["class"] += " active";
        //            break;
        //        case Tabs.Users:
        //            usersTab.Attributes["class"] += " active";
        //            break;
        //        case Tabs.Administration:
        //            adminTab.Attributes["class"] += " active";
        //            break;
        //        default:
        //            break;
        //    }

        //    rdCalendar.SelectedDate = DateTime.Today.Date;

        //    // accounts
        //    var accounts = from a in _db.Account
        //                   orderby a.Name
        //                   select a;

        //    rptAccounts.DataSource = accounts;
        //    rptAccounts.DataBind();

        //    // employees
        //    var employees = from emp in _db.Employee
        //                    orderby emp.LastName, emp.FirstName
        //                    select emp;

        //    rptEmployees.DataSource = employees;
        //    rptEmployees.DataBind();

        //    // asset types
        //    divAddNewAssetType.Visible = false;
        //    if (!Page.IsPostBack)
        //    {
        //        var assetCategories = from ac in _db.AssetCategory
        //                              orderby ac.Name
        //                              select ac;

        //        ddlAssetCategory.Items.Clear();

        //        foreach (AssetCategoryEntity ace in assetCategories)
        //        {
        //            ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
        //            ddlAssetCategory.Items.Add(li);
        //        }
        //    }

        //}

        //#endregion

        //#region Control Events

        //protected void btnAddNewAccount_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/EditAccount.aspx?acctId=0");
        //}

        //protected void btnAddNewEmployee_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/EditEmployee.aspx?employeeId=0");
        //}

        //protected void btnSaveAssetTypes_Click(object sender, EventArgs e)
        //{

        //}

        //protected void btnAddNewAssetType_Click(object sender, EventArgs e)
        //{
        //    divAddNewAssetType.Visible = true;
        //    hdnAssetTypeId.Value = "0";
        //}

        //protected void btnSaveAssetType_Click(object sender, EventArgs e)
        //{
        //    if (txtAssetTypeName.Text.Trim().Length > 0)
        //    {
        //        AssetTypeEntity ate = new AssetTypeEntity();
        //        ate.Name = txtAssetTypeName.Text.Trim();
        //        ate.AssetCategoryId = Convert.ToInt32(ddlAssetCategory.SelectedItem.Value);
        //        ate.Description = txtAssetTypeDescription.Text.Trim().Length > 0 ? txtAssetTypeDescription.Text.Trim() : null;
        //        ate.SpanishLabel = txtSpanishLabel.Text.Trim().Length > 0 ? txtSpanishLabel.Text.Trim() : null;
        //        ate.Save();

        //        Response.Redirect("Home.aspx?tab=" + ((int)Tabs.Administration).ToString());
        //    }
        //}

        //protected void rdCalendar_OnSelectionChanged(object sender, SelectedDatesEventArgs e)
        //{
        //    string date = e.SelectedDates.Count - 1 >= 0 ? e.SelectedDates[e.SelectedDates.Count - 1].Date.ToString() : "none";
        //    test.Text = date;
        //}

        //#endregion

        //#region Repeater Events

        //#region Accounts
        //protected void rptAccounts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.IsDataItem())
        //    {
        //        AccountEntity account = e.Item.DataItem as AccountEntity;

        //        LinkButton lnkBtnEditAccount = e.Item.FindControl("lnkBtnEditAccount") as LinkButton;
        //        Label lblAcctNo = e.Item.FindControl("lblAcctNo") as Label;
        //        Label lblAddress = e.Item.FindControl("lblAddress") as Label;
        //        Label lblPhone = e.Item.FindControl("lblPhone") as Label;

        //        lnkBtnEditAccount.Text = account.Name;
        //        lblAcctNo.Text = account.AccountNo != null ? account.AccountNo.Trim() : "";
        //        string address = "";

        //        if (account.Address1 != null)
        //        {
        //            address = account.Address1;
        //        }
        //        if (account.Address2 != null)
        //            address += ", " + account.Address2;
        //        if (account.City != null)
        //            address += " " + account.City;
        //        if (account.State != null)
        //            address += ", " + account.State;
        //        else address += ", " + account.IntlState;
        //        if (account.ZipCode != null)
        //            address += " " + account.ZipCode;

        //        lblAddress.Text = address;

        //        if (account.Phone != null && account.Phone.Length == 10)
        //        {
        //            string formattedPhone = account.Phone.Insert(0, "(");
        //            formattedPhone = formattedPhone.Insert(4, ") ");
        //            formattedPhone = formattedPhone.Insert(9, "-");
        //            lblPhone.Text = formattedPhone;
        //        }
        //        else
        //            lblPhone.Text = account.Phone;
        //    }
        //}

        //protected void rptAccounts_ItemCommand(object sender, RepeaterCommandEventArgs e)
        //{
        //    switch (e.CommandName)
        //    {
        //        case "Edit":
        //            Response.Redirect("~/EditAccount.aspx?acctId=" + e.CommandArgument.ToString());
        //            break;

        //        case "Delete":
        //            break;

        //        default:
        //            break;

        //    }
        //}
        //#endregion

        //#region Employees
        //protected void rptEmployees_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.IsDataItem())
        //    {
        //        EmployeeEntity employee = e.Item.DataItem as EmployeeEntity;

        //        LinkButton lnkBtnEditEmployee = e.Item.FindControl("lnkBtnEditEmployee") as LinkButton;
        //        Label lblSSN = e.Item.FindControl("lblSSN") as Label;
        //        Label lblEmployeeNo = e.Item.FindControl("lblEmployeeNo") as Label;
        //        Label lblAddress = e.Item.FindControl("lblAddress") as Label;
        //        Label lblPhone = e.Item.FindControl("lblPhone") as Label;

        //        lnkBtnEditEmployee.Text = employee.LastName + ", " + employee.FirstName;
        //        if (employee.Ssn != null && employee.Ssn.Length == 9)
        //        {
        //            string formattedSSN = employee.Ssn.Insert(3, "-");
        //            formattedSSN = formattedSSN.Insert(6, "-");
        //            lblSSN.Text = formattedSSN;
        //        }
        //        else
        //            lblSSN.Text = employee.Ssn;
        //        lblEmployeeNo.Text = employee.EmployeeNo != null ? employee.EmployeeNo.Trim() : "";
        //        string address = "";

        //        if (employee.Address1 != null)
        //        {
        //            address = employee.Address1;
        //        }
        //        if (employee.Address2 != null)
        //            address += ", " + employee.Address2;
        //        if (employee.City != null)
        //            address += " " + employee.City;
        //        if (employee.State != null)
        //            address += ", " + employee.State;
        //        else address += ", " + employee.IntlState;
        //        if (employee.ZipCode != null)
        //            address += " " + employee.ZipCode;

        //        lblAddress.Text = address;
        //        if (employee.Phone != null && employee.Phone.Length == 10)
        //        {
        //            string formattedPhone = employee.Phone.Insert(0, "(");
        //            formattedPhone = formattedPhone.Insert(4, ") ");
        //            formattedPhone = formattedPhone.Insert(9, "-");
        //            lblPhone.Text = formattedPhone;
        //        }
        //        else
        //            lblPhone.Text = employee.Phone;
        //    }
        //}

        //protected void rptEmployees_ItemCommand(object sender, RepeaterCommandEventArgs e)
        //{
        //    switch (e.CommandName)
        //    {
        //        case "Edit":
        //            Response.Redirect("~/EditEmployee.aspx?employeeId=" + e.CommandArgument.ToString());
        //            break;

        //        case "Delete":
        //            break;

        //        default:
        //            break;

        //    }
        //}

        //#endregion

        //#endregion

        //#region RadGrid Events
        //#region RadGrid Events
        //protected void rdAssetTypeGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        //{
        //    if (e.Item is GridDataItem)
        //    {
        //        if (e.Item.OwnerTableView.Name == "AssetTypeView")
        //        {
        //            var assetCategories = from ac in _db.AssetCategory
        //                                  orderby ac.Name
        //                                  select ac;

        //            AssetTypeEntity assetType = e.Item.DataItem as AssetTypeEntity;

        //            DropDownList ddlAssetTypeCategory = e.Item.FindControl("ddlAssetTypeCategory") as DropDownList;
        //            if (ddlAssetTypeCategory != null)
        //            {
        //                foreach (AssetCategoryEntity ace in assetCategories)
        //                {
        //                    ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
        //                    ddlAssetTypeCategory.Items.Add(li);
        //                }

        //                ddlAssetTypeCategory.SelectedValue = assetType.AssetCategoryId.ToString();
        //            }

        //            //foreach (GridDataItem assetTypeDataItem in e.Item.OwnerTableView.Items)
        //            //{
        //            //    Hashtable assetTypeValues = new Hashtable();
        //            //    assetTypeDataItem.ExtractValues(assetTypeValues);
        //            //    int assetTypeId = Convert.ToInt32(assetTypeValues["AssetTypeId"].ToString());

        //            //    DropDownList ddlAssetTypeCategory = dataItem.FindControl("ddlAssetTypeCategory") as DropDownList;

        //            //    if (ddlAssetCategory != null)
        //            //    {
        //            //        foreach (AssetCategoryEntity ace in assetCategories)
        //            //        {
        //            //            ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
        //            //            ddlAssetCategory.Items.Add(li);
        //            //        }
        //            //    }

        //            //}

        //        }
        //    }
        //}
        //protected void rdAssetTypeGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        //{
        //    if (!e.IsFromDetailTable)
        //    {
        //        var assetCategories = from ac in _db.AssetCategory
        //                              orderby ac.Name
        //                              select new
        //                              {
        //                                  AssetCategoryId = ac.AssetCategoryId,
        //                                  Name = ac.Name.ToUpper()
        //                              };

        //        rdAssetTypeGrid.DataSource = assetCategories;

        //    }
        //}
        //protected void rdAssetTypeGrid_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        //{
        //    GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
        //    Hashtable values = new Hashtable();
        //    dataItem.ExtractValues(values);

        //    int assetCategoryId = Convert.ToInt32(values["AssetCategoryId"].ToString());
        //    AssetCategoryEntity assetCategory = new AssetCategoryEntity(assetCategoryId);

        //    var assetTypes = from at in _db.AssetType
        //                     where at.AssetCategoryId == assetCategory.AssetCategoryId
        //                     orderby at.Name
        //                     select at;

        //    e.DetailTableView.DataSource = assetTypes;


        //}
        //#endregion
        //#endregion

        #endregion

    }
}
