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
    public partial class RecycleTypes : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divAddNewRecycleType.Visible = false;
            }
        }
        #endregion

        #region Control Events

        #region Recycle Types
        protected void btnSaveRecycleTypeChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem recycleItem in rdRecycleTypeGrid.Items)
            {
                Hashtable typeValues = new Hashtable();
                recycleItem.ExtractValues(typeValues);
                int recycleTypeId = Convert.ToInt32(typeValues["RecycleTypeId"].ToString());
                RecycleTypeEntity recycleType = new RecycleTypeEntity(recycleTypeId);

                TextBox txtName = recycleItem.FindControl("txtRecycleTypeName") as TextBox;
                TextBox txtRecycleTypeDescription = recycleItem.FindControl("txtRecycleTypeDescription") as TextBox;
                TextBox txtSpanishLabel = recycleItem.FindControl("txtSpanishLabel") as TextBox;

                recycleType.Name = txtName.Text.Trim().Length > 0 ? txtName.Text.Trim() : "";
                recycleType.Description = txtRecycleTypeDescription.Text.Trim().Length > 0 ? txtRecycleTypeDescription.Text.Trim() : "";
                recycleType.SpanishLabel = txtSpanishLabel.Text.Trim().Length > 0 ? txtSpanishLabel.Text.Trim() : "";

                recycleType.Save();

            }
        }

        protected void btnCancelRecycleTypeChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewRecycleType_Click(object sender, EventArgs e)
        {
            divAddNewRecycleType.Visible = true;
            hdnRecycleTypeId.Value = "0";

        }

        protected void btnSaveRecycleType_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                RecycleTypeEntity rte = new RecycleTypeEntity();
                rte.Name = txtName.Text.Trim();
                rte.Description = txtDescription.Text.Trim().Length > 0 ? txtDescription.Text.Trim() : null;
                rte.SpanishLabel = txtSpanishLabel.Text.Trim().Length > 0 ? txtSpanishLabel.Text.Trim() : null;
                rte.Save();

                txtName.Text = "";
                txtDescription.Text = "";
                txtSpanishLabel.Text = "";

                txtName.Focus();
                rdRecycleTypeGrid.Rebind();
            }
        }

        protected void btnCancelRecycleType_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtSpanishLabel.Text = "";
            divAddNewRecycleType.Visible = false;
        }

        protected void rdRecycleTypeGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var types = from r in _db.RecycleType
                            where r.IsActive
                            orderby r.Name
                            select r;

                rdRecycleTypeGrid.DataSource = types;

            }
        }

        public void rdRecycleTypeGrid_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var a = Convert.ToInt32(e.CommandArgument);
                var type = new RecycleTypeEntity(a);
                type.IsActive = false;
                type.Save();
            }
        }

        #endregion

        #endregion
    }
}