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
    public partial class EditUser : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private UserEntity _user = null;
        private List<UserAccountEntity> _userAccounts = new List<UserAccountEntity>();

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
        protected void Page_Init(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser == null)
                Response.Redirect("~/Default.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser.UserTypeId != (int)UserTypeEntity.UserTypes.Administrator)
            {
                Response.Redirect("NotAuthorized.aspx");
            }

            int userId = 0;
            int.TryParse(Request.QueryString["userId"], out userId);

            if (userId > 0)
            {
                _user = new UserEntity(userId);
                _userAccounts = _user.UserAccount.ToList();
            }
            else
                _user = new UserEntity();

            if (!Page.IsPostBack)
            {
                var userTypes = from ut in _db.UserType
                                orderby ut.Name
                                select ut;

                ddlUserType.Items.Clear();
                ddlUserType.Items.Add(new ListItem("", ""));
                foreach (UserTypeEntity ute in userTypes)
                {
                    ddlUserType.Items.Add(new ListItem(ute.Name, ute.UserTypeId.ToString()));
                }

                accountLists.Visible = false;

                // accounts
                var assetAccts = from a in _db.Account
                                     join s in _db.ServiceLocation on a.AccountId equals s.AccountId
                                     where s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly 
                                     && a.IsActive == true
                                     orderby a.Name
                                     select a;

                var oilAccts = from a in _db.Account
                               join s in _db.ServiceLocation on a.AccountId equals s.AccountId
                               where s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly 
                               && a.IsActive == true
                               orderby a.Name
                               select a;

                var recyclingAccts = from a in _db.Account
                               join s in _db.ServiceLocation on a.AccountId equals s.AccountId
                               where s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                               && a.IsActive == true
                               orderby a.Name
                               select a;

                dtListAsset.DataSource = assetAccts;
                dtListAsset.DataBind();
                dtListOilFiltration.DataSource = oilAccts;
                dtListOilFiltration.DataBind();
                dtListRecycle.DataSource = recyclingAccts;
                dtListRecycle.DataBind();

                populate();
            }

        }

        #endregion

        #region Private Methods
        private void populate()
        {
            if (!_user.IsNew)
            {
                userNameTitle.InnerText = _user.LastName + ", " + _user.FirstName;
                txtFirstName.Text = _user.FirstName;
                txtMiddleName.Text = _user.MiddleName;
                txtLastName.Text = _user.LastName;
                txtUsername.Text = _user.Username;
                txtEmailAddress.Text = _user.EmailAddress;
                ddlUserType.SelectedValue = _user.UserTypeId.ToString();

                if (ddlUserType.SelectedValue == ((int)UserTypeEntity.UserTypes.CompanyUser).ToString())
                {
                    accountLists.Visible = true;
                }
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

            if (ddlUserType.SelectedValue == "")
            {
                message = "Please select a user type.";
                ddlUserType.Focus();
            }

            if (txtEmailAddress.Text.Trim().Length > 0)
            {
                if (!txtEmailAddress.Text.Trim().IsValidEmailAddress())
                {
                    message = "Please enter a valid email address.";
                    txtEmailAddress.Focus();
                }
            }

            if (txtUsername.Text.Trim().Length > 0)
            {
                var existing = from usr in _db.User
                               where usr.Username.ToLower() == txtUsername.Text.Trim().ToLower()
                               select usr;

                if (existing.Count() > 0)
                {
                    if (existing.First().UserId != _user.UserId)
                    {
                        message = "There is already a user with this username.  Please choose a different username.";
                        txtUsername.Focus();
                    }
                }
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

        private void saveUserAccount(DataListItem dli)
        {
            HiddenField hdnAccountId = dli.FindControl("hdnAccountId") as HiddenField;
            int acctId = Convert.ToInt32(hdnAccountId.Value);
            AccountEntity acct = new AccountEntity(acctId);
            UserAccountEntity uae = new UserAccountEntity();

            if (_userAccounts.Where(x => x.AccountId == acct.AccountId).Count() > 0)
            {
                uae = _userAccounts.Where(x => x.AccountId == acct.AccountId).First();
            }

            CheckBox chkAccount = dli.FindControl("chkAccount") as CheckBox;
            if (chkAccount.Checked)
            {
                if (uae.IsNew)
                {
                    uae.UserId = _user.UserId;
                    uae.AccountId = acct.AccountId;
                    uae.Save();
                }
            }
            else
            {
                if (!uae.IsNew)
                {
                    _userAccounts.Remove(uae);
                    uae.Delete();
                }
            }
        }

        #endregion

        #region Control Events
        protected void btnSaveUser_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                _user.FirstName = txtFirstName.Text.Trim().Length > 0 ? txtFirstName.Text.Trim() : null;
                _user.MiddleName = txtMiddleName.Text.Trim().Length > 0 ? txtMiddleName.Text.Trim() : null;
                _user.LastName = txtLastName.Text.Trim().Length > 0 ? txtLastName.Text.Trim() : null;
                _user.EmailAddress = txtEmailAddress.Text.Trim().Length > 0 ? txtEmailAddress.Text.Trim() : null;
                _user.UserTypeId = Convert.ToInt32(ddlUserType.SelectedValue);
                _user.IsActive = true;
                _user.IsEnabled = true;

                _user.Username = txtUsername.Text.Trim().ToLower();

                if (txtPassword.Visible)
                    _user.Password = Hashing.ComputeHash(txtPassword.Text.Trim(), HashType.MD5);
                else
                {
                    _user.Password = Hashing.ComputeHash(txtNewPassword.Text.Trim(), HashType.MD5);
                }

                _user.Save();

                foreach (DataListItem dli in dtListAsset.Items)
                {
                    saveUserAccount(dli);
                }

                foreach (DataListItem dli in dtListOilFiltration.Items)
                {
                    saveUserAccount(dli);
                }

                foreach (DataListItem dli in dtListRecycle.Items)
                {
                    saveUserAccount(dli);
                }

                Response.Redirect("Users.aspx");
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Users.aspx");
        }

        protected void lnkBtnChangePassword_Click(object sender, EventArgs e)
        {
            divChangePassword.Visible = true;
            lblPassword.Visible = false;
            lnkBtnChangePassword.Visible = false;
            txtNewPassword.Focus();
        }

        protected void ddlUserType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlUserType.SelectedValue == ((int)UserTypeEntity.UserTypes.CompanyUser).ToString())
                accountLists.Visible = true;
            else
                accountLists.Visible = false;
        }

        protected void dtListAccount_OnItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                AccountEntity acct = e.Item.DataItem as AccountEntity;
                CheckBox chkAccount = (CheckBox)e.Item.FindControl("chkAccount");
                HiddenField hdnAccountId = (HiddenField)e.Item.FindControl("hdnAccountId");
                chkAccount.Text = acct.Name;
                chkAccount.Checked = _user.UserAccount.Where(x => x.AccountId == acct.AccountId).Count() > 0 ? true : false;
                hdnAccountId.Value = acct.AccountId.ToString();
            }
        }
        #endregion

    }
}
