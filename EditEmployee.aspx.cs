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

namespace RenuOil
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private EmployeeEntity _employee = null;
        public Tabs CurrentTab { get; set; }

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

        public enum Tabs
        {
            Info = 0
        }

        #endregion

        #region Page Events
        protected void Page_Init(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser == null)
                Response.Redirect("~/Default.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int employeeId = 0;
            int.TryParse(Request.QueryString["employeeId"], out employeeId);

            if (employeeId > 0)
                _employee = new EmployeeEntity(employeeId);
            else
                _employee = new EmployeeEntity();

            if (!Page.IsPostBack)
            {
                populate();
            }

        }

        #endregion

        #region Private Methods
        private void populate()
        {
            if (!_employee.IsNew)
            {
                employeeNameTitle.InnerText = _employee.LastName + ", " + _employee.FirstName;
                txtFirstName.Text = _employee.FirstName;
                txtMiddleName.Text = _employee.MiddleName;
                txtLastName.Text = _employee.LastName;
                txtEmployeeNo.Text = _employee.EmployeeNo;
                if (_employee.Ssn != null && _employee.Ssn.Length == 9)
                {
                    string formattedSSN = _employee.Ssn.Insert(3, "-");
                    formattedSSN = formattedSSN.Insert(6, "-");
                    txtSSN.Text = formattedSSN;
                }
                else
                    txtSSN.Text = _employee.Ssn;
                txtAddress1.Text = _employee.Address1;
                txtAddress2.Text = _employee.Address2;
                txtCity.Text = _employee.City;
                if (_employee.State != null)
                    ddlState.SelectedValue = _employee.State;
                txtZip.Text = _employee.ZipCode;
                if (_employee.Phone != null && _employee.Phone.Length == 10)
                {
                    string formattedPhone = _employee.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    txtPhone.Text = formattedPhone;
                }
                else
                    txtPhone.Text = _employee.Phone;

                txtUsername.Text = _employee.Username;

                txtPassword.Visible = false;
            }
            else
            {
                txtPassword.Visible = true;
                lnkBtnChangePassword.Visible = false;
            }
        }

        private string validate()
        {
            string message = "";

            if (txtFirstName.Text.Trim().Length == 0)
            {
                message = "An first name is required.";
                txtFirstName.Focus();
            }

            if (txtLastName.Text.Trim().Length == 0)
            {
                message = "A last name is required.";
                txtLastName.Focus();
            }
            if (txtSSN.Text.Trim().GetNumbers().Length > 9)
            {
                message = "Invalid SSN.";
                txtSSN.Focus();
            }

            if (txtNewPassword.Visible)
            {
                if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    message = "Passwords do not match.";
                    txtNewPassword.Focus();
                }
            }
            return message;
        }

        #endregion

        #region Control Events
        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                _employee.FirstName = txtFirstName.Text.Trim().Length > 0 ? txtFirstName.Text.Trim() : null;
                _employee.MiddleName = txtMiddleName.Text.Trim().Length > 0 ? txtMiddleName.Text.Trim() : null;
                _employee.LastName = txtLastName.Text.Trim().Length > 0 ? txtLastName.Text.Trim() : null;
                _employee.Ssn = txtSSN.Text.Trim().Length > 0 ? txtSSN.Text.Trim().GetNumbers() : null;
                _employee.EmployeeNo = txtEmployeeNo.Text.Trim().Length > 0 ? txtEmployeeNo.Text.Trim() : null;
                _employee.Address1 = txtAddress1.Text.Trim().Length > 0 ? txtAddress1.Text.Trim() : null;
                _employee.Address2 = txtAddress2.Text.Trim().Length > 0 ? txtAddress2.Text.Trim() : null;
                _employee.City = txtCity.Text.Trim().Length > 0 ? txtCity.Text.Trim() : null;
                _employee.State = ddlState.SelectedValue.Length > 0 ? ddlState.SelectedValue : null; ;
                _employee.ZipCode = txtZip.Text.Trim().Length > 0 ? txtZip.Text.Trim() : null;
                _employee.Phone = txtPhone.Text.Trim().GetNumbers().Length > 0 ? txtPhone.Text.Trim().GetNumbers() : null;
                _employee.IsActive = true;
                _employee.IsEnabled = true;

                if (txtUsername.Text.Trim().Length > 0)
                    _employee.Username = txtUsername.Text.Trim().ToLower();
                else
                    _employee.Username = null;

                if (txtPassword.Visible && txtPassword.Text.Trim().Length > 0)
                {
                    _employee.Password = Hashing.ComputeHash(txtPassword.Text.Trim(), HashType.MD5);
                }
                else if (txtNewPassword.Visible)
                {
                    if (txtNewPassword.Text.Trim().Length > 0)
                        _employee.Password = Hashing.ComputeHash(txtNewPassword.Text.Trim(), HashType.MD5);
                    else
                        _employee.Password = null;
                }
                else
                    _employee.Password = null;

                _employee.Save();

                Response.Redirect("~/Employees.aspx");
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees.aspx");
        }

        protected void lnkBtnChangePassword_Click(object sender, EventArgs e)
        {
            divChangePassword.Visible = true;
            lblPassword.Visible = false;
            lnkBtnChangePassword.Visible = false;
            txtNewPassword.Focus();
        }

        #endregion

    }
}
