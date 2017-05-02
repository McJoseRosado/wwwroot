using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.Linq;
using System.Collections;
using Telerik.Web.UI;
using Reliant.RenuOil.DAL.EntityClasses;

namespace RenuOil
{
    public partial class RebateTypes : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divAddNewRebateType.Visible = false;
            }
        }
        #endregion

        #region Control Events

        #region Rebate Types
        protected void btnSaveRebateTypeChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem recycleItem in rdRebateTypeGrid.Items)
            {
                Hashtable typeValues = new Hashtable();
                recycleItem.ExtractValues(typeValues);
                int rebateTypeId = Convert.ToInt32(typeValues["RebateTypeId"].ToString());
                RebateTypeEntity recycleType = new RebateTypeEntity(rebateTypeId);

                TextBox txtName = recycleItem.FindControl("txtRebateTypeName") as TextBox;
                recycleType.Name = txtName.Text.Trim().Length > 0 ? txtName.Text.Trim() : "";
                recycleType.Save();

            }
        }

        protected void btnCancelRebateTypeChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewRebateType_Click(object sender, EventArgs e)
        {
            divAddNewRebateType.Visible = true;
            hdnRebateTypeId.Value = "0";

        }

        protected void btnSaveRebateType_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                RebateTypeEntity rte = new RebateTypeEntity();
                rte.Name = txtName.Text.Trim();
                rte.Save();

                txtName.Text = "";

                txtName.Focus();
                rdRebateTypeGrid.Rebind();
            }
        }

        protected void btnCancelRebateType_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            divAddNewRebateType.Visible = false;
        }

        protected void rdRebateTypeGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var types = from r in _db.RebateType
                            where r.IsActive
                            orderby r.Name
                            select r;

                rdRebateTypeGrid.DataSource = types.ToList();

            }
        }

        public void rdRebateTypeGrid_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var a = Convert.ToInt32(e.CommandArgument);
                var type = new RebateTypeEntity(a);
                type.IsActive = false;
                type.Save();
            }
        }

        #endregion

        #endregion
    }
}