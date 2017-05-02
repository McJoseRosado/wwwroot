using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.Linq;
using ReliantUtilityLibrary;
using System.Collections;
using Telerik.Web.UI;
using Reliant.RenuOil.DAL.EntityClasses;

namespace RenuOil
{
    public partial class Rebates : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                divAddNewRebate.Visible = false;
                populateComboBoxes();
            }
        }

        #endregion

        #region Control Events

        private void populateComboBoxes()
        {
            ddlRebateType.Bind(_db.RebateType.Where(r => r.IsActive).OrderBy(r => r.Name).ToList(), "Name", "RebateTypeId");
            ddlRebateAccount.Bind(_db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList(), "Name", "AccountId");
        }

        #region Vendors
        protected void btnSaveRebateChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem vendorItem in rdRebate.Items)
            {
                Hashtable typeValues = new Hashtable();
                vendorItem.ExtractValues(typeValues);
                int rebateId = Convert.ToInt32(typeValues["RebateId"].ToString());
                RebateEntity rebate = new RebateEntity(rebateId);

                RadDatePicker rdpDate = vendorItem.FindControl("rdpDate") as RadDatePicker;
                TextBox txtAmount = vendorItem.FindControl("txtAmount") as TextBox;
                DropDownList ddlType = vendorItem.FindControl("ddlType") as DropDownList;
                DropDownList ddlAccount = vendorItem.FindControl("ddlAccount") as DropDownList;

                var amount = 0M;
                Decimal.TryParse(txtAmount.Text, out amount);
                rebate.Amount = amount;
                rebate.RebateTypeId = Convert.ToInt32(ddlType.SelectedValue);
                rebate.RebateDate = rdpDate.SelectedDate.GetValueOrDefault(DateTime.Today);
                rebate.AccountId = Convert.ToInt32(ddlAccount.SelectedValue);
                rebate.Save();
            }
        }

        protected void btnCancelRebateChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewRebate_Click(object sender, EventArgs e)
        {
            divAddNewRebate.Visible = true;
            hdnRebateId.Value = "0";
        }

        protected void btnSaveRebate_Click(object sender, EventArgs e)
        {
            var amount = 0M;
            if (decimal.TryParse(txtRebateAmount.Text, out amount))
            {
                RebateEntity r = new RebateEntity();
                r.Amount = amount;
                r.RebateTypeId = Convert.ToInt32(ddlRebateType.SelectedValue);
                r.AccountId = Convert.ToInt32(ddlRebateAccount.SelectedValue);
                r.RebateDate = rdpDate.SelectedDate.GetValueOrDefault(DateTime.Now);
                r.EnteredByUserId = sm.AuthenticatedUser.UserId;
                r.EnteredDate = DateTime.Now;
                r.Save();

                txtRebateAmount.Text = "";

                txtRebateAmount.Focus();
                rdpDate.SelectedDate = null;
                ddlRebateAccount.SelectedIndex = 0;
                ddlRebateType.SelectedIndex = 0;
                rdRebate.Rebind();
            }
        }

        protected void btnCancelRebate_Click(object sender, EventArgs e)
        {
            txtRebateAmount.Text = "";
            divAddNewRebate.Visible = false;
        }

        protected void rdRebate_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var types = from r in _db.Rebate
                            where r.RebateDate.Month == DateTime.Today.Month
                            orderby r.RebateDate ascending
                            select r;

                rdRebate.DataSource = types;
            }
        }

        public void rdRebate_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var v = new RebateEntity(Convert.ToInt32(e.CommandArgument));
                v.Delete();
            }
        }

        protected void rdRebate_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                RebateEntity v = e.Item.DataItem as RebateEntity;
                DropDownList ddlType = e.Item.FindControl("ddlType") as DropDownList;
                var types = _db.RebateType.Where(r=>r.IsActive).OrderBy(r => r.Name).ToList();
                foreach (var item in types)
                {
                    ListItem li = new ListItem(item.Name, item.RebateTypeId.ToString());
                    ddlType.Items.Add(li);
                }
                if (ddlType != null)
                {
                    ddlType.SelectedValue = v.RebateTypeId.ToString();
                }
                
                DropDownList ddlAccount = e.Item.FindControl("ddlAccount") as DropDownList;
                var accounts = _db.Account.Where(r => r.IsActive).OrderBy(r => r.Name).ToList();
                foreach (var item in accounts)
                {
                    ListItem li = new ListItem(item.Name, item.AccountId.ToString());
                    ddlAccount.Items.Add(li);
                }
                if (ddlAccount != null)
                {
                    ddlAccount.SelectedValue = v.AccountId.ToString();
                }
            }
        }

        #endregion

        #endregion
    }
}