using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReliantUtilityLibrary;
using Reliant.RenuOil.DAL.Linq;
using Reliant.RenuOil.DAL.EntityClasses;

namespace RenuOil
{
    public partial class BeginWorkOrder : System.Web.UI.Page
    {
        private int _typeId;

        private LinqMetaData _db = new LinqMetaData();

        protected void Page_Load(object sender, EventArgs e)
        {
            populateComboBoxes();

            _typeId = 0;
            int.TryParse(Request.QueryString["serviceType"], out _typeId);

            if (!IsPostBack)
            {
                if (_typeId != 0)
                {
                    ddlType.SelectedValue = _typeId.ToString();
                    ddlType_SelectedIndexChanged(this, null);
                }
            }

            populateAccounts();
        }

        private void populateAccounts()
        {
            var accounts = _db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList();
            if (ddlType.SelectedValue != "0")
            {
                var typeId = Convert.ToInt32(ddlType.SelectedValue);
                accounts = (from a in accounts
                            join s in _db.ServiceLocation on a.AccountId equals s.AccountId
                            where s.ServiceTypeId == typeId
                            select a).ToList();
            }
            rptAccounts.Bind(accounts.Distinct().ToList());
        }

        private void populateComboBoxes()
        {
            var serviceTypes = _db.ServiceType.OrderBy(d => d.Name).ToList();
            serviceTypes.Add(new Reliant.RenuOil.DAL.EntityClasses.ServiceTypeEntity() { Name = "All", Description = "All", ServiceTypeId = 0 });
            ddlType.Bind(serviceTypes, "Description", "ServiceTypeId");
            ddlType.SelectedValue = "0";
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateAccounts();
        }

        protected void rptAccounts_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "BeginWorkOrder":
                    Response.Redirect("~/EditWorkOrder.aspx?acctId=" + e.CommandArgument.ToString() + "&serviceType=" + _typeId.ToString());
                    break;
                default:
                    break;
            }
        }

        protected void rptAccounts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                AccountEntity account = e.Item.DataItem as AccountEntity;

                LinkButton lnkBtnEditAccount = e.Item.FindControl("lnkBtnEditAccount") as LinkButton;
                Label lblAcctNo = e.Item.FindControl("lblAcctNo") as Label;
                Label lblAddress = e.Item.FindControl("lblAddress") as Label;
                Label lblPhone = e.Item.FindControl("lblPhone") as Label;
                Label lblLastService = e.Item.FindControl("lblLastService") as Label;

                lnkBtnEditAccount.Text = account.Name;
                lblAcctNo.Text = account.AccountNo != null ? account.AccountNo.Trim() : "";

                if (account.Phone != null && account.Phone.Length == 10)
                {
                    string formattedPhone = account.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    lblPhone.Text = formattedPhone;
                }
                else
                {
                    lblPhone.Text = account.Phone;
                }

                if (lblLastService != null)
                {
                    lblLastService.Text = account.LastServiceDate;
                }
            }
        }
    }
}