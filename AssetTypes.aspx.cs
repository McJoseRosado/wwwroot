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
using Telerik.Web.UI.Calendar;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using System.Collections;

namespace RenuOil
{
    public partial class AssetTypes : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

        #endregion

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // asset types

                if (!Page.IsPostBack)
                {
                    var assetCategories = from ac in _db.AssetCategory
                                          orderby ac.Name
                                          select ac;

                    ddlAssetCategory.Items.Clear();

                    foreach (AssetCategoryEntity ace in assetCategories)
                    {
                        ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
                        ddlAssetCategory.Items.Add(li);
                    }
                }

                divAddNewAssetType.Visible = false;
                divAddNewAssetCategory.Visible = false;
            }
        }
        #endregion

        #region Control Events

        #region Asset Types
        protected void btnSaveAssetTypeChanges_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem assetCategoryItem in rdAssetTypeGrid.Items)
            {
                GridNestedViewItem detailView = (GridNestedViewItem)assetCategoryItem.ChildItem;

                if (detailView != null)
                {
                    GridTableView tableView = detailView.NestedTableViews.First();
                    foreach (GridDataItem assetTypeItem in tableView.Items)
                    {
                        Hashtable assetTypeValues = new Hashtable();
                        assetTypeItem.ExtractValues(assetTypeValues);
                        int assetTypeId = Convert.ToInt32(assetTypeValues["AssetTypeId"].ToString());
                        AssetTypeEntity assetType = new AssetTypeEntity(assetTypeId);

                        TextBox txtName = assetTypeItem.FindControl("txtName") as TextBox;
                        TextBox txtAssetTypeDescription = assetTypeItem.FindControl("txtAssetTypeDescription") as TextBox;
                        TextBox txtSpanishLabel = assetTypeItem.FindControl("txtSpanishLabel") as TextBox;
                        DropDownList ddlAssetTypeCategory = assetTypeItem.FindControl("ddlAssetTypeCategory") as DropDownList;

                        assetType.Name = txtName.Text.Trim().Length > 0 ? txtName.Text.Trim() : "";
                        assetType.Description = txtAssetTypeDescription.Text.Trim().Length > 0 ? txtAssetTypeDescription.Text.Trim() : "";
                        assetType.SpanishLabel = txtSpanishLabel.Text.Trim().Length > 0 ? txtSpanishLabel.Text.Trim() : "";
                        assetType.AssetCategoryId = Convert.ToInt32(ddlAssetTypeCategory.SelectedValue);

                        assetType.Save();
                    }
                }
            }
        }

        protected void btnCancelAssetTypeChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddNewAssetType_Click(object sender, EventArgs e)
        {
            divAddNewAssetType.Visible = true;
            divAddNewAssetCategory.Visible = false;
            hdnAssetTypeId.Value = "0";

        }

        protected void btnSaveAssetType_Click(object sender, EventArgs e)
        {
            if (txtAssetTypeName.Text.Trim().Length > 0)
            {
                AssetTypeEntity ate = new AssetTypeEntity();
                ate.Name = txtAssetTypeName.Text.Trim();
                ate.AssetCategoryId = Convert.ToInt32(ddlAssetCategory.SelectedItem.Value);
                ate.Description = txtAssetTypeDescription.Text.Trim().Length > 0 ? txtAssetTypeDescription.Text.Trim() : null;
                ate.SpanishLabel = txtAssetTypeSpanishLabel.Text.Trim().Length > 0 ? txtAssetTypeSpanishLabel.Text.Trim() : null;
                ate.Save();

                txtAssetTypeName.Text = "";
                txtAssetTypeDescription.Text = "";
                txtAssetTypeSpanishLabel.Text = "";

                txtAssetTypeName.Focus();
                rdAssetTypeGrid.Rebind();
            }
        }

        protected void btnCancelAssetType_Click(object sender, EventArgs e)
        {
            txtAssetTypeName.Text = "";
            txtAssetTypeDescription.Text = "";
            txtAssetTypeSpanishLabel.Text = "";
            divAddNewAssetType.Visible = false;
        }

        #endregion

        #region Asset Categories
        protected void btnAddNewAssetCategory_Click(object sender, EventArgs e)
        {
            divAddNewAssetCategory.Visible = true;
            divAddNewAssetType.Visible = false;
            hdnAssetCategoryId.Value = "0";
        }

        protected void btnSaveAssetCategory_Click(object sender, EventArgs e)
        {
            AssetCategoryEntity ace = new AssetCategoryEntity();
            ace.Name = txtAssetCategoryName.Text.Trim();
            ace.Description = txtAssetCategoryDescription.Text.Trim().Length > 0 ? txtAssetCategoryDescription.Text.Trim() : null;
            ace.SpanishLabel = txtAssetCategorySpanishLabel.Text.Trim().Length > 0 ? txtAssetCategorySpanishLabel.Text.Trim() : null;
            ace.Save();

            txtAssetCategoryName.Text = "";
            txtAssetCategoryDescription.Text = "";
            txtAssetCategorySpanishLabel.Text = "";

            var assetCategories = from ac in _db.AssetCategory
                                  orderby ac.Name
                                  select ac;

            ddlAssetCategory.Items.Clear();

            foreach (AssetCategoryEntity ac in assetCategories)
            {
                ListItem li = new ListItem(ac.Name, ac.AssetCategoryId.ToString());
                ddlAssetCategory.Items.Add(li);
            }

            txtAssetCategoryName.Focus();
            rdAssetTypeGrid.Rebind();
        }


        protected void btnCancelAssetCategory_Click(object sender, EventArgs e)
        {
            txtAssetCategoryName.Text = "";
            txtAssetCategoryDescription.Text = "";
            txtAssetCategorySpanishLabel.Text = "";
            divAddNewAssetCategory.Visible = false;
        }


        #endregion

        #endregion

        #region RadGrid Events
        protected void rdAssetTypeGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                if (e.Item.OwnerTableView.Name == "AssetTypeView")
                {
                    var assetCategories = from ac in _db.AssetCategory
                                          orderby ac.Name
                                          select ac;

                    AssetTypeEntity assetType = e.Item.DataItem as AssetTypeEntity;

                    DropDownList ddlAssetTypeCategory = e.Item.FindControl("ddlAssetTypeCategory") as DropDownList;
                    if (ddlAssetTypeCategory != null)
                    {
                        foreach (AssetCategoryEntity ace in assetCategories)
                        {
                            ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
                            ddlAssetTypeCategory.Items.Add(li);
                        }

                        ddlAssetTypeCategory.SelectedValue = assetType.AssetCategoryId.ToString();
                    }

                    //foreach (GridDataItem assetTypeDataItem in e.Item.OwnerTableView.Items)
                    //{
                    //    Hashtable assetTypeValues = new Hashtable();
                    //    assetTypeDataItem.ExtractValues(assetTypeValues);
                    //    int assetTypeId = Convert.ToInt32(assetTypeValues["AssetTypeId"].ToString());

                    //    DropDownList ddlAssetTypeCategory = dataItem.FindControl("ddlAssetTypeCategory") as DropDownList;

                    //    if (ddlAssetCategory != null)
                    //    {
                    //        foreach (AssetCategoryEntity ace in assetCategories)
                    //        {
                    //            ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
                    //            ddlAssetCategory.Items.Add(li);
                    //        }
                    //    }

                    //}

                }
            }
        }
        protected void rdAssetTypeGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var assetCategories = from ac in _db.AssetCategory
                                      orderby ac.Name
                                      select new
                                      {
                                          AssetCategoryId = ac.AssetCategoryId,
                                          Name = ac.Name.ToUpper()
                                      };

                rdAssetTypeGrid.DataSource = assetCategories;

            }
        }
        protected void rdAssetTypeGrid_DetailTableDataBind(object source, Telerik.Web.UI.GridDetailTableDataBindEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
            Hashtable values = new Hashtable();
            dataItem.ExtractValues(values);

            int assetCategoryId = Convert.ToInt32(values["AssetCategoryId"].ToString());
            AssetCategoryEntity assetCategory = new AssetCategoryEntity(assetCategoryId);

            var assetTypes = from at in _db.AssetType
                             where at.AssetCategoryId == assetCategory.AssetCategoryId
                             orderby at.Name
                             select at;

            e.DetailTableView.DataSource = assetTypes;


        }
        #endregion
    }
}
