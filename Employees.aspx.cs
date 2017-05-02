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
    public partial class Employees : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

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
            // employees
            populate();
        }

        private void populate()
        {
            var employees = from emp in _db.Employee
                            where emp.IsActive
                            orderby emp.LastName, emp.FirstName
                            select emp;

            rptEmployees.DataSource = employees;
            rptEmployees.DataBind();
        }

        #endregion

        #region Control Events
        protected void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditEmployee.aspx?employeeId=0");
        }

        protected void lbDelete_OnClick(object sender, EventArgs e)
        {
            var id = int.Parse(((LinkButton)sender).CommandArgument);
            var employee = _db.Employee.FirstOrDefault(emp => emp.EmployeeId == id);
            if (employee != null)
            {
                employee.IsActive = false;
                employee.Save();
            }
            populate();
        }
        #endregion

        #region Repeater Events
        protected void rptEmployees_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                EmployeeEntity employee = e.Item.DataItem as EmployeeEntity;

                LinkButton lnkBtnEditEmployee = e.Item.FindControl("lnkBtnEditEmployee") as LinkButton;
                Label lblSSN = e.Item.FindControl("lblSSN") as Label;
                Label lblEmployeeNo = e.Item.FindControl("lblEmployeeNo") as Label;
                Label lblAddress = e.Item.FindControl("lblAddress") as Label;
                Label lblPhone = e.Item.FindControl("lblPhone") as Label;

                lnkBtnEditEmployee.Text = employee.LastName + ", " + employee.FirstName;
                //if (employee.Ssn != null && employee.Ssn.Length == 9)
                //{
                //    string formattedSSN = employee.Ssn.Insert(3, "-");
                //    formattedSSN = formattedSSN.Insert(6, "-");
                //    lblSSN.Text = formattedSSN;
                //}
                //else
                //    lblSSN.Text = employee.Ssn;
                //lblEmployeeNo.Text = employee.EmployeeNo != null ? employee.EmployeeNo.Trim() : "";
                //string address = "";

                //if (employee.Address1 != null)
                //{
                //    address = employee.Address1;
                //}
                //if (employee.Address2 != null)
                //    address += ", " + employee.Address2;
                //if (employee.City != null)
                //    address += " " + employee.City;
                //if (employee.State != null)
                //    address += ", " + employee.State;
                //else address += ", " + employee.IntlState;
                //if (employee.ZipCode != null)
                //    address += " " + employee.ZipCode;

                //lblAddress.Text = address;
                if (employee.Phone != null && employee.Phone.Length == 10)
                {
                    string formattedPhone = employee.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    lblPhone.Text = formattedPhone;
                }
                else
                    lblPhone.Text = employee.Phone;
            }
        }

        protected void rptEmployees_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditEmployee.aspx?employeeId=" + e.CommandArgument.ToString());
                    break;

                case "Delete":
                    break;

                default:
                    break;

            }
        }

        #endregion
    }
}
