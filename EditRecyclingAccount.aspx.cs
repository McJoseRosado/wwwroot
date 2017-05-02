using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.Linq;
using Reliant.RenuOil.DAL.EntityClasses;
using ReliantUtilityLibrary;
using Telerik.Web.UI;

namespace RenuOil
{
    public partial class EditRecyclingAccount : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private ServiceLocationEntity _serviceLocation = null;
        private AccountEntity _account = null;

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
            int acctId = 0;
            int.TryParse(Request.QueryString["acctId"], out acctId);

            if (acctId > 0)
            {
                _account = new AccountEntity(acctId);
                instructions.Visible = false;

                var serviceLocations = from sl in _db.ServiceLocation
                                       where sl.AccountId == _account.AccountId
                                       orderby sl.Name
                                       select sl;

                _serviceLocation = serviceLocations.First();

            }
            else
            {
                _account = new AccountEntity();
                //_account.AccountType = "Recycling";
            }

            if (!Page.IsPostBack)
            {
                populate();
            }
        }
        #endregion

        #region Methods
        private string validate()
        {
            string message = "";

            if (txtAcctName.Text.Trim().Length == 0)
            {
                message = "An account name is required.";
                txtAcctName.Focus();
            }

            return message;
        }

        protected void populate()
        {
            if (!_account.IsNew)
            {
                accountNameTitle.InnerText = _account.Name;
                txtAcctName.Text = _account.Name;
                txtAcctNo.Text = _account.AccountNo;
                txtAddress1.Text = _account.Address1;
                txtAddress2.Text = _account.Address2;
                txtCity.Text = _account.City;
                if (_account.State != null)
                    ddlState.SelectedValue = _account.State;
                txtZip.Text = _account.ZipCode;
                if (_account.Phone != null && _account.Phone.Length == 10)
                {
                    string formattedPhone = _account.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    txtPhone.Text = formattedPhone;
                }
                else
                    txtPhone.Text = _account.Phone;
                txtMainContact.Text = _account.MainContact;
                txtNotes.Text = _account.Notes;
            }
            else
            {
                accountNameTitle.InnerText = "Add New Recycling Account:";
                txtAcctName.Focus();
            }
        }

        #endregion

        #region Control Events
        protected void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                _account.Name = txtAcctName.Text.Trim();
                _account.AccountNo = txtAcctNo.Text.Trim().Length > 0 ? txtAcctNo.Text.Trim() : null;
                _account.Address1 = txtAddress1.Text.Trim().Length > 0 ? txtAddress1.Text.Trim() : null;
                _account.Address2 = txtAddress2.Text.Trim().Length > 0 ? txtAddress2.Text.Trim() : null;
                _account.City = txtCity.Text.Trim().Length > 0 ? txtCity.Text.Trim() : null;
                _account.State = ddlState.SelectedValue.Length > 0 ? ddlState.SelectedValue : null; ;
                _account.ZipCode = txtZip.Text.Trim().Length > 0 ? txtZip.Text.Trim() : null;
                _account.Phone = txtPhone.Text.Trim().GetNumbers().Length > 0 ? txtPhone.Text.Trim().GetNumbers() : null;
                _account.IsActive = true;
                _account.MainContact = txtMainContact.Text.Trim().Length > 0 ? txtMainContact.Text.Trim() : null;
                _account.Notes = txtNotes.Text.Trim().Length > 0 ? txtNotes.Text.Trim() : null;

                if (_account.IsNew)
                {
                    _serviceLocation = new ServiceLocationEntity();
                    _serviceLocation.Account = _account;
                }

                _serviceLocation.Name = _account.Name;
                _serviceLocation.Address1 = _account.Address1;
                _serviceLocation.Address2 = _account.Address2;
                _serviceLocation.City = _account.City;
                _serviceLocation.ZipCode = _account.ZipCode;
                _serviceLocation.MainContact = _account.MainContact;
                _serviceLocation.Notes = _account.Notes;
                _serviceLocation.Phone = _account.Phone;
                _serviceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.RecycleOnly;

                _account.Save();
                _serviceLocation.Save();

                Response.Redirect("~/EditRecyclingAccount.aspx?acctId=" + _account.AccountId.ToString());
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssetReclamationAccounts.aspx");
        }

        #endregion

        #region Repeater Events

        protected void rptChanges_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                ServiceLocationAssetTypeChangeLogEntity dfcl = e.Item.DataItem as ServiceLocationAssetTypeChangeLogEntity;
                Label lblDate = e.Item.FindControl("lblDate") as Label;
                Label lblUsername = e.Item.FindControl("lblUsername") as Label;
                Label lblRevisionInfo = e.Item.FindControl("lblRevisionInfo") as Label;

                lblDate.Text = dfcl.ChangeLog.ChangeDate.ToShortDateString() + " " +
                    dfcl.ChangeLog.ChangeDate.ToLongTimeString();
                lblUsername.Text = dfcl.ChangeLog.User.Username;
                lblRevisionInfo.Text = dfcl.ChangeLog.ChangeType.Description;
            }
        }
        #endregion

    }
}