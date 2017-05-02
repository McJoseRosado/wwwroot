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
    public partial class AssetReclamationAccounts : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            // accounts
            var accounts = from a in _db.Account
                           //where a.AccountType == "AssetReclamation"
                           //&& a.IsActive == true
                           orderby a.Name
                           select a;

            rptAccounts.DataSource = accounts;
            rptAccounts.DataBind();
        }
        #endregion

        #region Control Events

        protected void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditAssetReclamationAccount.aspx?acctId=0");
        }

        #endregion

        #region Repeater Events

        #region Accounts
        protected void rptAccounts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                AccountEntity account = e.Item.DataItem as AccountEntity;

                LinkButton lnkBtnEditAccount = e.Item.FindControl("lnkBtnEditAccount") as LinkButton;
                Label lblAcctNo = e.Item.FindControl("lblAcctNo") as Label;
                Label lblAddress = e.Item.FindControl("lblAddress") as Label;
                Label lblPhone = e.Item.FindControl("lblPhone") as Label;

                lnkBtnEditAccount.Text = account.Name;
                lblAcctNo.Text = account.AccountNo != null ? account.AccountNo.Trim() : "";
                string address = "";

                //if (account.Address1 != null)
                //{
                //    address = account.Address1;
                //}
                //if (account.Address2 != null)
                //    address += ", " + account.Address2;
                //if (account.City != null)
                //    address += " " + account.City;
                //if (account.State != null)
                //    address += ", " + account.State;
                //else address += ", " + account.IntlState;
                //if (account.ZipCode != null)
                //    address += " " + account.ZipCode;

                //lblAddress.Text = address;

                if (account.Phone != null && account.Phone.Length == 10)
                {
                    string formattedPhone = account.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    lblPhone.Text = formattedPhone;
                }
                else
                    lblPhone.Text = account.Phone;
            }
        }

        protected void rptAccounts_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditAssetReclamationAccount.aspx?acctId=" + e.CommandArgument.ToString());
                    break;

                case "Delete":
                    int accountId = Convert.ToInt32(e.CommandArgument);
                    AccountEntity acct = new AccountEntity(accountId);
                    acct.IsActive = false;
                    acct.Save();

                    // accounts
                    var accounts = from a in _db.Account
                                   //where a.AccountType == "AssetReclamation"
                                   //&& a.IsActive == true
                                   orderby a.Name
                                   select a;

                    rptAccounts.DataSource = accounts;
                    rptAccounts.DataBind();
                    break;

                default:
                    break;

            }
        }
        #endregion

        #endregion
    }
}
