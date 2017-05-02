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
namespace RenuOil
{
    public partial class FiltrationSchedules : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private List<EmployeeEntity> _employees = null;

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
            _employees = (from emp in _db.Employee
                          orderby emp.LastName, emp.FirstName
                          select emp).ToList();

            if (!Page.IsPostBack)
                populate();

        }

        #endregion

        #region Methods
        private void populate()
        {
            var accounts = from a in _db.Account
                           where a.IsActive == true
                           //&& a.AccountType == "OilFiltration"
                           orderby a.Name
                           select a;

            rdAccountGrid.DataSource = accounts;
            rdAccountGrid.DataBind();

        }

        private void SaveAssignments()
        {
            foreach (GridDataItem item in rdAccountGrid.Items)
            {
                GridNestedViewItem detailView = (GridNestedViewItem)item.ChildItem;
                if (detailView != null)
                {
                    GridTableView tableView = detailView.NestedTableViews.First();

                    if (tableView.Name == "WeekView")
                    {
                        foreach (GridDataItem childItem in tableView.Items)
                        {
                            Hashtable values = new Hashtable();
                            childItem.ExtractValues(values);

                            int aeaeId = Convert.ToInt32(values["AccountEmployeeAssignmentId"].ToString());
                            AccountEmployeeAssignmentEntity acctEmployeeAssgnmnt = new AccountEmployeeAssignmentEntity(aeaeId);

                            if (acctEmployeeAssgnmnt != null)
                            {
                                List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                                foreach (string day in days)
                                {
                                    DropDownList ddlEmployees = childItem.FindControl("ddlEmployees" + day) as DropDownList;
                                    if (ddlEmployees.SelectedValue != "")
                                        acctEmployeeAssgnmnt.GetFieldByName(day).CurrentValue = Convert.ToInt32(ddlEmployees.SelectedValue);
                                    else
                                        acctEmployeeAssgnmnt.GetFieldByName(day).CurrentValue = null;
                                }

                                acctEmployeeAssgnmnt.IsDirty = true;
                                acctEmployeeAssgnmnt.Save();
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Control Events
        protected void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            SaveAssignments();
            populate();
            messages.Add(HtmlHelper.Div("success", "Schedule Saved"));
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }


        protected void ddlEmployees_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlEmployees = sender as DropDownList;

            string selectedEmployeeId = ddlEmployees.SelectedValue;
            // header dropdowns are named "ddlEmployeesHeader[NameOfDay]", we want just the day
            string day = ddlEmployees.ID.Substring(18);

            Control xx = ddlEmployees.Parent;
            GridTableView tableView = ddlEmployees.Parent.Parent.Parent.Parent.Parent as GridTableView;

            foreach (GridDataItem item in tableView.Items)
            {
                DropDownList ddlEmployee = item.FindControl("ddlEmployees" + day) as DropDownList;
                ddlEmployee.SelectedValue = selectedEmployeeId;
            }
        }

        #endregion

        #region RadGrid Events
        protected void rdAccountGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                if (e.Item.OwnerTableView.Name == "MasterView")
                {
                    AccountEntity account = e.Item.DataItem as AccountEntity;
                    Label lblAccountName = e.Item.FindControl("lblAccountName") as Label;

                    if (lblAccountName != null)
                    {
                        lblAccountName.Text = account.Name;
                    }
                }
                else if (e.Item.OwnerTableView.Name == "WeekView")
                {
                    AccountEmployeeAssignmentEntity aeae = e.Item.DataItem as AccountEmployeeAssignmentEntity;
                    DropDownList ddlEmployeesMonday = e.Item.FindControl("ddlEmployeesMonday") as DropDownList;
                    DropDownList ddlEmployeesTuesday = e.Item.FindControl("ddlEmployeesTuesday") as DropDownList;
                    DropDownList ddlEmployeesWednesday = e.Item.FindControl("ddlEmployeesWednesday") as DropDownList;
                    DropDownList ddlEmployeesThursday = e.Item.FindControl("ddlEmployeesThursday") as DropDownList;
                    DropDownList ddlEmployeesFriday = e.Item.FindControl("ddlEmployeesFriday") as DropDownList;
                    DropDownList ddlEmployeesSaturday = e.Item.FindControl("ddlEmployeesSaturday") as DropDownList;
                    DropDownList ddlEmployeesSunday = e.Item.FindControl("ddlEmployeesSunday") as DropDownList;

                    if (ddlEmployeesMonday != null)
                    {
                        ddlEmployeesMonday.Items.Add(new ListItem("", ""));
                        ddlEmployeesTuesday.Items.Add(new ListItem("", ""));
                        ddlEmployeesWednesday.Items.Add(new ListItem("", ""));
                        ddlEmployeesThursday.Items.Add(new ListItem("", ""));
                        ddlEmployeesFriday.Items.Add(new ListItem("", ""));
                        ddlEmployeesSaturday.Items.Add(new ListItem("", ""));
                        ddlEmployeesSunday.Items.Add(new ListItem("", ""));

                        foreach (EmployeeEntity emp in _employees)
                        {
                            ListItem li1 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesMonday.Items.Add(li1);

                            ListItem li2 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesTuesday.Items.Add(li2);

                            ListItem li3 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesWednesday.Items.Add(li3);

                            ListItem li4 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesThursday.Items.Add(li4);

                            ListItem li5 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesFriday.Items.Add(li5);

                            ListItem li6 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesSaturday.Items.Add(li6);

                            ListItem li7 = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                            ddlEmployeesSunday.Items.Add(li7);
                        }

                        var accountEmployeeAssignment = from aea in _db.AccountEmployeeAssignment
                                                        where aea.AccountId == aeae.AccountId
                                                        select aea;

                        if (accountEmployeeAssignment.Count() > 0)
                        {
                            AccountEmployeeAssignmentEntity aea = accountEmployeeAssignment.First();
                            ddlEmployeesMonday.SelectedValue = aea.Monday != null ? aea.Monday.ToString() : "";
                            ddlEmployeesTuesday.SelectedValue = aea.Tuesday != null ? aea.Tuesday.ToString() : "";
                            ddlEmployeesWednesday.SelectedValue = aea.Wednesday != null ? aea.Wednesday.ToString() : "";
                            ddlEmployeesThursday.SelectedValue = aea.Thursday != null ? aea.Thursday.ToString() : "";
                            ddlEmployeesFriday.SelectedValue = aea.Friday != null ? aea.Friday.ToString() : "";
                            ddlEmployeesSaturday.SelectedValue = aea.Saturday != null ? aea.Saturday.ToString() : "";
                            ddlEmployeesSunday.SelectedValue = aea.Sunday != null ? aea.Sunday.ToString() : "";
                        }
                    }
                }

            }
            else
            {
                DropDownList ddlEmployeesHeaderMonday = e.Item.FindControl("ddlEmployeesHeaderMonday") as DropDownList;
                DropDownList ddlEmployeesHeaderTuesday = e.Item.FindControl("ddlEmployeesHeaderTuesday") as DropDownList;
                DropDownList ddlEmployeesHeaderWednesday = e.Item.FindControl("ddlEmployeesHeaderWednesday") as DropDownList;
                DropDownList ddlEmployeesHeaderThursday = e.Item.FindControl("ddlEmployeesHeaderThursday") as DropDownList;
                DropDownList ddlEmployeesHeaderFriday = e.Item.FindControl("ddlEmployeesHeaderFriday") as DropDownList;
                DropDownList ddlEmployeesHeaderSaturday = e.Item.FindControl("ddlEmployeesHeaderSaturday") as DropDownList;
                DropDownList ddlEmployeesHeaderSunday = e.Item.FindControl("ddlEmployeesHeaderSunday") as DropDownList;

                if (ddlEmployeesHeaderMonday != null)
                {

                    ListItem blankli = new ListItem("", "");
                    ddlEmployeesHeaderMonday.Items.Add(blankli);
                    ddlEmployeesHeaderTuesday.Items.Add(blankli);
                    ddlEmployeesHeaderWednesday.Items.Add(blankli);
                    ddlEmployeesHeaderThursday.Items.Add(blankli);
                    ddlEmployeesHeaderFriday.Items.Add(blankli);
                    ddlEmployeesHeaderSaturday.Items.Add(blankli);
                    ddlEmployeesHeaderSunday.Items.Add(blankli);

                    foreach (EmployeeEntity emp in _employees)
                    {
                        ListItem li = new ListItem(emp.LastName + ", " + emp.FirstName, emp.EmployeeId.ToString());
                        ddlEmployeesHeaderMonday.Items.Add(li);
                        ddlEmployeesHeaderTuesday.Items.Add(li);
                        ddlEmployeesHeaderWednesday.Items.Add(li);
                        ddlEmployeesHeaderThursday.Items.Add(li);
                        ddlEmployeesHeaderFriday.Items.Add(li);
                        ddlEmployeesHeaderSaturday.Items.Add(li);
                        ddlEmployeesHeaderSunday.Items.Add(li);
                    }
                }
            }
        }

        protected void rdAccountGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            //if (!e.IsFromDetailTable)
            //{
            //    var serviceLocations = from sl in _db.ServiceLocation
            //                           where sl.AccountId == _account.AccountId
            //                           orderby sl.Name
            //                           select sl;

            //    rdAccountGrid.DataSource = serviceLocations;

            //}
        }

        protected void rdAccountGrid_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
            Hashtable values = new Hashtable();
            dataItem.ExtractValues(values);

            int accountId = Convert.ToInt32(values["AccountId"].ToString());
            AccountEntity account = new AccountEntity(accountId);

            var accountEmployeeAssignment = from aea in _db.AccountEmployeeAssignment
                                            where aea.AccountId == account.AccountId
                                            select aea;

            if (accountEmployeeAssignment.Count() == 0)
            {
                AccountEmployeeAssignmentEntity aeae = new AccountEmployeeAssignmentEntity();
                aeae.AccountId = accountId;
                aeae.Save();
            }

            e.DetailTableView.DataSource = account.AccountEmployeeAssignment.ToList();
        }
        #endregion

    }
}
