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

namespace RenuOil
{
    public partial class Vendors : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divAddNewVendor.Visible = false;
            }
        }
        #endregion

        #region Control Events

        #region Vendors
        protected void btnSaveVendorChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem vendorItem in rdVendors.Items)
            {
                Hashtable typeValues = new Hashtable();
                vendorItem.ExtractValues(typeValues);
                int recycleVendorId = Convert.ToInt32(typeValues["RecycleVendorId"].ToString());
                RecycleVendorEntity recycleVendor = new RecycleVendorEntity(recycleVendorId);

                TextBox txtName = vendorItem.FindControl("txtName") as TextBox;
                DropDownList ddlType = vendorItem.FindControl("ddlType") as DropDownList;

                recycleVendor.Name = txtName.Text.Trim().Length > 0 ? txtName.Text.Trim() : "";
                recycleVendor.Type = ddlType.SelectedValue == "O" ? "Open-top Landfill" : "Landfill Compactor";

                recycleVendor.Save();

            }
        }

        protected void btnCancelVendorChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewVendor_Click(object sender, EventArgs e)
        {
            divAddNewVendor.Visible = true;
            hdnVendorId.Value = "0";

        }

        protected void btnSaveVendor_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                RecycleVendorEntity v = new RecycleVendorEntity();
                v.Name = txtName.Text.Trim();
                v.Type = ddlType.SelectedValue;
                v.Save();

                txtName.Text = "";

                txtName.Focus();
                rdVendors.Rebind();
            }
        }

        protected void btnCancelVendor_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            divAddNewVendor.Visible = false;
        }

        protected void rdVendors_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var types = from r in _db.RecycleVendor
                            where r.IsActive
                            orderby r.Name
                            select r;

                rdVendors.DataSource = types;

            }
        }

        public void rdVendors_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var v = new RecycleVendorEntity(Convert.ToInt32(e.CommandArgument));
                v.IsActive = false;
                v.Save();
            }
        }

        protected void rdVendors_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                DropDownList ddlType = e.Item.FindControl("ddlType") as DropDownList;
                if (ddlType != null)
                {
                    RecycleVendorEntity v = e.Item.DataItem as RecycleVendorEntity;
                    ddlType.SelectedValue = v.Type;
                }
            }
        }

        #endregion

        #endregion
    }
}