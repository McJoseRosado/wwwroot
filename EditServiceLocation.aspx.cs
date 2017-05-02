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
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using System.Collections;

namespace RenuOil
{
    public partial class EditServiceLocation : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private ServiceLocationEntity _serviceLocation = null;
        private AccountEntity _account = null;
        private DeepFryerEntity _currentFryer = null;
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

        protected void Page_Init(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser == null)
                Response.Redirect("~/Default.aspx");

            int serviceLocationId = 0;
            int.TryParse(Request.QueryString["id"], out serviceLocationId);
            int acctId = 0;
            int.TryParse(Request.QueryString["acctId"], out acctId);
            int serviceTypeId = 0;
            int.TryParse(Request.QueryString["type"], out serviceTypeId);

            if (serviceLocationId > 0)
            {
                _serviceLocation = new ServiceLocationEntity(serviceLocationId);
                _account = _serviceLocation.Account;
                instructions.Visible = false;
                fryersDiv.Visible = true;
                revisionDiv.Visible = true;
                btnDeleteServiceLocation.Visible = true;
            }
            else if (acctId > 0)
            {
                _serviceLocation = new ServiceLocationEntity();
                _serviceLocation.AccountId = acctId;
                _serviceLocation.ServiceTypeId = serviceTypeId;
                _serviceLocation.IsActive = true;
                _account = new AccountEntity(acctId);
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //fryersDiv.Visible = false;
            //assetTypesDiv.Visible = false;
            if (!Page.IsPostBack)
            {
                populate();
            }

        }


        #region Methods

        private void populate()
        {
            if (!_serviceLocation.IsNew)
            {
                if (_serviceLocation.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly)
                {
                    fryersDiv.Visible = true;

                    var fryers = from df in _db.DeepFryer
                                 where df.ServiceLocationId == _serviceLocation.ServiceLocationId
                                 orderby df.Name
                                 select df;

                    List<DeepFryerChangeLogEntity> changes = new List<DeepFryerChangeLogEntity>();

                    foreach (DeepFryerEntity fryer in fryers)
                    {

                        var revisions = from dfcl in _db.DeepFryerChangeLog
                                        join df in _db.DeepFryer on dfcl.DeepFryerId equals df.DeepFryerId
                                        where df.ServiceLocationId == _serviceLocation.ServiceLocationId
                                        && dfcl.DeepFryerId == fryer.DeepFryerId
                                        orderby dfcl.ChangeLog.ChangeDate descending
                                        select dfcl;

                        if (revisions.Count() > 0)
                            changes.Add(revisions.First());
                    }

                    rptChanges.DataSource = changes.OrderByDescending(x => x.ChangeLog.ChangeDate).ThenBy(x => x.DeepFryer.Name);
                    rptChanges.DataBind();

                    //assetTypesDiv.Visible = false;
                }
                else if (_serviceLocation.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly)
                {
                    fryersDiv.Visible = false;
                    //assetTypesDiv.Visible = true;

                }

                serviceLocationTitle.InnerText = _serviceLocation.Name;
                txtServiceLocationName.Text = _serviceLocation.Name;
                txtAddress1.Text = _serviceLocation.Address1;
                txtAddress2.Text = _serviceLocation.Address2;
                txtCity.Text = _serviceLocation.City;
                if (_serviceLocation.State != null)
                    ddlState.SelectedValue = _serviceLocation.State;
                txtZip.Text = _serviceLocation.ZipCode;
                txtPhone.Text = _serviceLocation.Phone;
                txtMainContact.Text = _serviceLocation.MainContact;
                txtNotes.Text = _serviceLocation.Notes;

                txtNotes.Height = 160;
            }
            else
            {
                serviceLocationTitle.InnerText = "Add New Restaurant Outlet for:  " + _serviceLocation.Account.Name;
                txtServiceLocationName.Focus();

                if (_serviceLocation.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly)
                {
                    instructionmessage.InnerText = "You will be able to add fryers after you save the restaurant outlet.";
                }
            }
        }

        private string validate()
        {
            string message = "";

            if (txtServiceLocationName.Text.Trim().Length == 0)
            {
                message = "A restaurant outlet name is required.";
                txtServiceLocationName.Focus();
            }

            return message;
        }
        #endregion

        #region Control Events

        protected void btnSaveServiceLocation_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                _serviceLocation.Name = txtServiceLocationName.Text.Trim();
                _serviceLocation.Address1 = txtAddress1.Text.Trim().Length > 0 ? txtAddress1.Text.Trim() : null;
                _serviceLocation.Address2 = txtAddress2.Text.Trim().Length > 0 ? txtAddress2.Text.Trim() : null;
                _serviceLocation.City = txtCity.Text.Trim().Length > 0 ? txtCity.Text.Trim() : null;
                _serviceLocation.State = ddlState.SelectedValue.Length > 0 ? ddlState.SelectedValue.Trim() : null;
                _serviceLocation.ZipCode = txtZip.Text.Trim().Length > 0 ? txtZip.Text.Trim() : null;
                _serviceLocation.Phone = txtPhone.Text.Trim().GetNumbers().Length > 0 ? txtPhone.Text.Trim().GetNumbers() : null;
                _serviceLocation.MainContact = txtMainContact.Text.Trim().Length > 0 ? txtMainContact.Text.Trim() : null;
                _serviceLocation.Notes = txtNotes.Text.Trim().Length > 0 ? txtNotes.Text.Trim() : null;
                _serviceLocation.Save();

                Response.Redirect("~/EditServiceLocation.aspx?id=" + _serviceLocation.ServiceLocationId.ToString());
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }

        protected void btnCancel_Click2(object sender, EventArgs e)
        {
            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }

        protected void btnAddNewFryer_Click(object sender, EventArgs e)
        {
            divAddNewFryer.Visible = true;
            hdnDeepFryerId.Value = "0";
            txtDeepFryerName.Text = "";
            txtDeepFryerDescription.Text = "";
            txtSizeInGallons.Text = "";
            txtDeepFryerName.Focus();
            btnAddNewFryer.Visible = false;
        }

        protected void btnSaveDeepFryer_Click(object sender, EventArgs e)
        {
            if (txtDeepFryerName.Text.Trim().Length > 0)
            {
                _currentFryer = new DeepFryerEntity(Convert.ToInt32(hdnDeepFryerId.Value));
                double sizeInGallons = 0;

                if (txtSizeInGallons.Text.Trim().Length > 0)
                {
                    try
                    {
                        sizeInGallons = Convert.ToDouble(txtSizeInGallons.Text.Trim());
                    }
                    catch
                    {
                        //TODO
                    }
                }
                _currentFryer.Name = txtDeepFryerName.Text.Trim();
                _currentFryer.Description = txtDeepFryerDescription.Text.Trim().Length > 0 ? txtDeepFryerDescription.Text.Trim() : null;
                _currentFryer.ServiceLocationId = _serviceLocation.ServiceLocationId;
                if (sizeInGallons > 0)
                    _currentFryer.SizeInGallons = sizeInGallons;
                else
                    _currentFryer.SizeInGallons = null;
                _currentFryer.Save();

                ChangeLogEntity cle = new ChangeLogEntity();
                cle.UserId = sm.AuthenticatedUser.UserId;
                cle.ChangeDate = DateTime.Now;
                cle.ChangeTypeId = (int)ChangeTypeEntity.ChangeTypes.FryerAdded;
                DeepFryerChangeLogEntity dfcle = new DeepFryerChangeLogEntity();
                dfcle.DeepFryerId = _currentFryer.DeepFryerId;
                dfcle.ChangeLog = cle;
                dfcle.Save(true);

                rdFryersGrid.Rebind();
                divAddNewFryer.Visible = false;
                btnAddNewFryer.Visible = true;
                //    Response.Redirect("~/EditServiceLocation.aspx?serviceLocationId=" + _currentFryer.ServiceLocationId.ToString() + "&tab=1");
            }
        }

        protected void btnSaveFryers_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem item in rdFryersGrid.Items)
            {
                TextBox txtDeepFryerName = item.FindControl("txtDeepFryerName") as TextBox;
                TextBox txtDeepFryerDescription = item.FindControl("txtDeepFryerDescription") as TextBox;
                TextBox txtDeepFryerSizeInGallons = item.FindControl("txtDeepFryerSizeInGallons") as TextBox;
                HiddenField hdnDeepFryerId = item.FindControl("hdnDeepFryerId") as HiddenField;
                HiddenField hdnOrigSize = item.FindControl("hdnOrigSize") as HiddenField;

                if (hdnDeepFryerId != null)
                {
                    DeepFryerEntity deepFryer = new DeepFryerEntity(Convert.ToInt32(hdnDeepFryerId.Value));
                    deepFryer.Name = txtDeepFryerName.Text.Trim();
                    deepFryer.Description = txtDeepFryerDescription.Text.Trim();
                    if (deepFryer.SizeInGallons != null)
                    {
                        try
                        {
                            double orgSize = Convert.ToDouble(hdnOrigSize.Value);
                            double newSize = Convert.ToDouble(txtDeepFryerSizeInGallons.Text.Trim());

                            if (orgSize != newSize)
                            {
                                ChangeLogEntity cle = new ChangeLogEntity();
                                cle.UserId = sm.AuthenticatedUser.UserId;
                                cle.ChangeDate = DateTime.Now;
                                cle.ChangeTypeId = newSize > orgSize ? (int)ChangeTypeEntity.ChangeTypes.FryerSizeIncrease : (int)ChangeTypeEntity.ChangeTypes.FryerSizeDecrease;
                                DeepFryerChangeLogEntity dfcle = new DeepFryerChangeLogEntity();
                                dfcle.DeepFryerId = deepFryer.DeepFryerId;
                                dfcle.ChangeLog = cle;
                                dfcle.Save(true);

                            }
                        }
                        catch { }
                    }


                    if (txtDeepFryerSizeInGallons.Text.Trim().Length > 0)
                    {
                        deepFryer.SizeInGallons = Convert.ToDouble(txtDeepFryerSizeInGallons.Text.Trim());
                    }



                    deepFryer.Save();
                }
            }

            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());

        }

        protected void btnCancelFryers_Click(object sender, EventArgs e)
        {
            populate();
            rdFryersGrid.Rebind();
            divAddNewFryer.Visible = false;
            btnAddNewFryer.Visible = true;
            txtDeepFryerName.Text = "";
            txtDeepFryerDescription.Text = "";
            txtSizeInGallons.Text = "";
            hdnDeepFryerId.Value = "0";

            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }

        protected void btnDeleteServiceLocation_Click(object sender, EventArgs e)
        {
            _serviceLocation.IsActive = false;
            _serviceLocation.Save();

            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }

        #endregion

        #region Repeater Events
        protected void rptFryers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                DeepFryerEntity deepFryer = e.Item.DataItem as DeepFryerEntity;

                LinkButton lnkBtnEditDeepFryer = e.Item.FindControl("lnkBtnEditDeepFryer") as LinkButton;
                Label lblDeepFryerDescription = e.Item.FindControl("lblDeepFryerDescription") as Label;
                Label lblSizeInGallons = e.Item.FindControl("lblSizeInGallons") as Label;
                HiddenField hdnDeepFryerId = e.Item.FindControl("hdnDeepFryerId") as HiddenField;

                hdnDeepFryerId.Value = deepFryer.DeepFryerId.ToString();
                lnkBtnEditDeepFryer.Text = deepFryer.Name;
                lblDeepFryerDescription.Text = deepFryer.Description != null ? deepFryer.Description : "";
                lnkBtnEditDeepFryer.ToolTip = deepFryer.Description != null ? deepFryer.Description : "";
                lblSizeInGallons.Text = deepFryer.SizeInGallons != null ? deepFryer.SizeInGallons.Value.ToString() : "";
            }
        }

        protected void rptFryers_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    //hdnDeepFryerId.Value = e.CommandArgument.ToString();
                    //_currentFryer = new DeepFryerEntity(Convert.ToInt32(hdnDeepFryerId.Value));
                    //txtDeepFryerName.Text = _currentFryer.Name;
                    //txtDeepFryerDescription.Text = _currentFryer.Description != null ? _currentFryer.Description : "";
                    //txtSizeInGallons.Text = _currentFryer.SizeInGallons != null ? _currentFryer.SizeInGallons.Value.ToString() : "";
                    //divAddNewFryer.Visible = true;
                    break;

                case "Delete":
                    break;

                default:
                    break;

            }
        }

        protected void rptChanges_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                DeepFryerChangeLogEntity dfcl = e.Item.DataItem as DeepFryerChangeLogEntity;
                Label lblDate = e.Item.FindControl("lblDate") as Label;
                Label lblUsername = e.Item.FindControl("lblUsername") as Label;
                Label lblFryerName = e.Item.FindControl("lblFryerName") as Label;
                Label lblRevisionInfo = e.Item.FindControl("lblRevisionInfo") as Label;

                lblDate.Text = dfcl.ChangeLog.ChangeDate.ToShortDateString() + " " +
                    dfcl.ChangeLog.ChangeDate.ToLongTimeString();
                lblUsername.Text = dfcl.ChangeLog.User.Username;
                lblFryerName.Text = dfcl.DeepFryer.Name.ToUpper();
                lblRevisionInfo.Text = dfcl.ChangeLog.ChangeType.Description;
            }
        }

        #endregion

        #region RadGrid Events

        #region rdFryersGrid
        protected void rdFryersGrid_OnDataBinding(object source, EventArgs e)
        {

        }

        protected void rdFryersGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem)
            {
                //if (e.Item.OwnerTableView.Name == "AssetTypeView")
                //{
                //    AssetTypeEntity assetType = e.Item.DataItem as AssetTypeEntity;

                //    TextBox txtPricePerUnit = e.Item.FindControl("txtPricePerUnit") as TextBox;

                //    if (txtPricePerUnit != null)
                //    {
                //        var serviceLocationAssetType = (from slat in _db.ServiceLocationAssetType
                //                                        where slat.AssetTypeId == assetType.AssetTypeId
                //                                        && slat.ServiceLocationId == _serviceLocation.ServiceLocationId
                //                                        select slat).ToList();

                //        if (serviceLocationAssetType.Count() == 0)
                //        {
                //            ServiceLocationAssetTypeEntity slat = new ServiceLocationAssetTypeEntity();
                //            slat.ServiceLocationId = _serviceLocation.ServiceLocationId;
                //            slat.AssetTypeId = assetType.AssetTypeId;
                //            slat.PricePerUnit = 0;
                //            slat.Save();

                //            txtPricePerUnit.Text = slat.PricePerUnit.ToString("C");
                //        }
                //        else
                //        {
                //            ServiceLocationAssetTypeEntity slat = serviceLocationAssetType.First();
                //            txtPricePerUnit.Text = slat.PricePerUnit.ToString("C");
                //        }

                //    }

                //    //foreach (GridDataItem assetTypeDataItem in e.Item.OwnerTableView.Items)
                //    //{
                //    //    Hashtable assetTypeValues = new Hashtable();
                //    //    assetTypeDataItem.ExtractValues(assetTypeValues);
                //    //    int assetTypeId = Convert.ToInt32(assetTypeValues["AssetTypeId"].ToString());

                //    //    DropDownList ddlAssetTypeCategory = dataItem.FindControl("ddlAssetTypeCategory") as DropDownList;

                //    //    if (ddlAssetCategory != null)
                //    //    {
                //    //        foreach (AssetCategoryEntity ace in assetCategories)
                //    //        {
                //    //            ListItem li = new ListItem(ace.Name, ace.AssetCategoryId.ToString());
                //    //            ddlAssetCategory.Items.Add(li);
                //    //        }
                //    //    }

                //    //}

                //}
            }
        }

        protected void rdFryersGrid_OnItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    HiddenField hdnDeepFryerId = e.Item.FindControl("hdnDeepFryerId") as HiddenField;

                    if (hdnDeepFryerId != null)
                    {
                        DeepFryerEntity deepFryer = new DeepFryerEntity(Convert.ToInt32(hdnDeepFryerId.Value));
                        deepFryer.IsActive = false;
                        deepFryer.Save();

                        ChangeLogEntity cle = new ChangeLogEntity();
                        cle.UserId = sm.AuthenticatedUser.UserId;
                        cle.ChangeDate = DateTime.Now;
                        cle.ChangeTypeId = (int)ChangeTypeEntity.ChangeTypes.FryerRemoved;
                        DeepFryerChangeLogEntity dfcle = new DeepFryerChangeLogEntity();
                        dfcle.DeepFryerId = deepFryer.DeepFryerId;
                        dfcle.ChangeLog = cle;
                        dfcle.Save(true);
                    }
                    break;

                default:
                    break;
            }
        }

        protected void rdFryersGrid_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var fryers = from df in _db.DeepFryer
                             where df.ServiceLocationId == _serviceLocation.ServiceLocationId
                             && df.IsActive == true
                             orderby df.Name
                             select df;

                rdFryersGrid.DataSource = fryers;

                if (fryers.Count() > 0)
                {
                    rdFryersGrid.Visible = true;
                    btnSaveFryers.Visible = true;
                    btnCancelFryers.Visible = true;
                }
                else
                {
                    rdFryersGrid.Visible = false;
                    btnSaveFryers.Visible = false;
                    btnCancelFryers.Visible = false;
                }

            }
        }

        #endregion

        #endregion

    }
}
