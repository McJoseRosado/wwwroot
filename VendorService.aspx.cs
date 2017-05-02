using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.Linq;
using Telerik.Web.UI;
using System.Collections;
using Reliant.RenuOil.DAL.EntityClasses;
using ReliantUtilityLibrary;

namespace RenuOil
{
    public partial class VendorService : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divAddNewVendorService.Visible = false;
                populateComboBoxes();
            }
        }

        #endregion

        #region Control Events

        private void populateComboBoxes()
        {
            ddlRecycleVendor.Bind(_db.RecycleVendor.Where(r => r.IsActive).OrderBy(r => r.Name).ToList(), "Name", "RecycleVendorId");
            ddlRecycleType.Bind(_db.RecycleType.Where(r => r.IsActive).OrderBy(r => r.Name).ToList(), "Name", "RecycleTypeId");
            ddlRecycleAccount.Bind(_db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList(), "Name", "AccountId");
        }

        #region Vendors
        protected void btnSaveVendorChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem vendorItem in rdVendorService.Items)
            {
                Hashtable typeValues = new Hashtable();
                vendorItem.ExtractValues(typeValues);
                int serviceId = Convert.ToInt32(typeValues["RecycleVendorServiceId"].ToString());
                RecycleVendorServiceEntity recycleVendor = new RecycleVendorServiceEntity(serviceId);

                RadDatePicker rdpDate = vendorItem.FindControl("rdpDate") as RadDatePicker;
                TextBox txtWeight = vendorItem.FindControl("txtWeight") as TextBox;
                DropDownList ddlRecycleType = vendorItem.FindControl("ddlType") as DropDownList;
                DropDownList ddlVendor = vendorItem.FindControl("ddlVendor") as DropDownList;
                DropDownList ddlAccount = vendorItem.FindControl("ddlAccount") as DropDownList;
                TextBox txtTotalMonthlyPulls = vendorItem.FindControl("txtTotalMonthlyPulls") as TextBox;
                TextBox txtTotalMonthlyWeight = vendorItem.FindControl("txtTotalMonthlyWeight") as TextBox;

                var weight = 0M;
                var totalMonthlyWeight = 0M;
                Decimal.TryParse(txtWeight.Text, out weight);
                Decimal.TryParse(txtTotalMonthlyWeight.Text, out totalMonthlyWeight);
                recycleVendor.Weight = weight;
                recycleVendor.RecycleTypeId = Convert.ToInt32(ddlRecycleType.SelectedValue);
                recycleVendor.RecycleVendorId = Convert.ToInt32(ddlRecycleVendor.SelectedValue);
                recycleVendor.ServiceDate = rdpDate.SelectedDate.GetValueOrDefault(DateTime.Today);
                recycleVendor.AccountId = Convert.ToInt32(ddlAccount.SelectedValue);
                recycleVendor.TotalMonthlyPulls = Convert.ToInt32(txtTotalMonthlyPulls.Text);
                recycleVendor.TotalMonthlyWeight = totalMonthlyWeight;
                recycleVendor.Save();
            }
        }

        protected void btnCancelVendorChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewVendorService_Click(object sender, EventArgs e)
        {
            divAddNewVendorService.Visible = true;
            hdnVendorServiceId.Value = "0";

        }

        protected void btnSaveVendorService_Click(object sender, EventArgs e)
        {
            var weight = 0M;
            var totalMonthlyWeight = 0M;
            if (decimal.TryParse(txtWeight.Text, out weight) &&
                decimal.TryParse(txtTotalMonthlyWeight.Text, out totalMonthlyWeight))
            {
                RecycleVendorServiceEntity v = new RecycleVendorServiceEntity();
                v.Weight = weight;
                v.RecycleVendorId = Convert.ToInt32(ddlRecycleVendor.SelectedValue);
                v.RecycleTypeId = Convert.ToInt32(ddlRecycleType.SelectedValue);
                v.TotalMonthlyPulls = Convert.ToInt32(txtTotalMonthlyPulls.Text);
                v.TotalMonthlyWeight = totalMonthlyWeight;
                v.AccountId = Convert.ToInt32(ddlRecycleAccount.SelectedValue);
                v.Save();

                txtWeight.Text = "";

                txtWeight.Focus();
                rdVendorService.Rebind();
            }
        }

        protected void btnCancelVendorService_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            divAddNewVendorService.Visible = false;
        }

        protected void rdVendorService_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var types = from r in _db.RecycleVendorService
                            where r.ServiceDate.Month == DateTime.Today.Month
                            orderby r.ServiceDate ascending
                            select r;

                rdVendorService.DataSource = types;
            }
        }

        public void rdVendorService_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var v = new RecycleVendorServiceEntity(Convert.ToInt32(e.CommandArgument));
                v.Delete();
            }
        }

        protected void rdVendorService_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                RecycleVendorServiceEntity v = e.Item.DataItem as RecycleVendorServiceEntity;
                DropDownList ddlType = e.Item.FindControl("ddlType") as DropDownList;
                var types = _db.RecycleType.OrderBy(r => r.Name).ToList();
                foreach (var item in types)
                {
                    ListItem li = new ListItem(item.Name, item.RecycleTypeId.ToString());
                    ddlType.Items.Add(li);
                }                
                if (ddlType != null)
                {
                    ddlType.SelectedValue = v.RecycleTypeId.ToString();
                }

                DropDownList ddlVendors = e.Item.FindControl("ddlVendor") as DropDownList;
                var vendors = _db.RecycleVendor.Where(r=>r.IsActive).OrderBy(r => r.Name).ToList();
                foreach (var item in vendors)
                {
                    ListItem li = new ListItem(item.Name, item.RecycleVendorId.ToString());
                    ddlVendors.Items.Add(li);
                }
                if (ddlVendors != null)
                {
                    ddlVendors.SelectedValue = v.RecycleVendorId.ToString();
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