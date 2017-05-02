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
    public partial class EditAssetReclamationAccount : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private ServiceLocationEntity _serviceLocation = null;
        private AccountEntity _account = null;

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
            int acctId = 0;
            int.TryParse(Request.QueryString["acctId"], out acctId);

            if (acctId > 0)
            {
                _account = new AccountEntity(acctId);
                instructions.Visible = false;

                var serviceLocations = from sl in _db.ServiceLocation
                                       where sl.AccountId == _account.AccountId
                                       orderby sl.Name
                                       select sl;

                _serviceLocation = serviceLocations.First();

            }
            else
            {
                _account = new AccountEntity();
                //_account.AccountType = "AssetReclamation";
                assetTypesDiv.Visible = false;
            }

            if (!Page.IsPostBack)
            {
                populate();
            }
        }
        #endregion

        #region Methods
        private string validate()
        {
            string message = "";

            if (txtAcctName.Text.Trim().Length == 0)
            {
                message = "An account name is required.";
                txtAcctName.Focus();
            }

            return message;
        }

        protected void populate()
        {
            if (!_account.IsNew)
            {
                accountNameTitle.InnerText = _account.Name;
                txtAcctName.Text = _account.Name;
                txtAcctNo.Text = _account.AccountNo;
                txtAddress1.Text = _account.Address1;
                txtAddress2.Text = _account.Address2;
                txtCity.Text = _account.City;
                if (_account.State != null)
                    ddlState.SelectedValue = _account.State;
                txtZip.Text = _account.ZipCode;
                if (_account.Phone != null && _account.Phone.Length == 10)
                {
                    string formattedPhone = _account.Phone.Insert(0, "(");
                    formattedPhone = formattedPhone.Insert(4, ") ");
                    formattedPhone = formattedPhone.Insert(9, "-");
                    txtPhone.Text = formattedPhone;
                }
                else
                    txtPhone.Text = _account.Phone;
                txtMainContact.Text = _account.MainContact;
                txtNotes.Text = _account.Notes;

                var revisions = from slatcl in _db.ServiceLocationAssetTypeChangeLog
                                join slat in _db.ServiceLocationAssetType on slatcl.ServiceLocationAssetTypeId equals slat.ServiceLocationAssetTypeId
                                where slat.ServiceLocationId == _serviceLocation.ServiceLocationId
                                orderby slatcl.ChangeLog.ChangeDate descending
                                select slatcl;

                if (revisions.Count() > 0)
                {
                    rptChanges.DataSource = revisions.OrderByDescending(x => x.ChangeLog.ChangeDate);
                    rptChanges.DataBind();
                }
            }
            else
            {
                //string serviceType = _account.AccountType == "OilFiltration" ? "Oil Filtration" : "Asset Reclamation / Recycling";
                //accountNameTitle.InnerText = "Add New " + serviceType + " Account:";
                txtAcctName.Focus();
            }
        }

        #endregion

        #region Control Events
        protected void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                _account.Name = txtAcctName.Text.Trim();
                _account.AccountNo = txtAcctNo.Text.Trim().Length > 0 ? txtAcctNo.Text.Trim() : null;
                _account.Address1 = txtAddress1.Text.Trim().Length > 0 ? txtAddress1.Text.Trim() : null;
                _account.Address2 = txtAddress2.Text.Trim().Length > 0 ? txtAddress2.Text.Trim() : null;
                _account.City = txtCity.Text.Trim().Length > 0 ? txtCity.Text.Trim() : null;
                _account.State = ddlState.SelectedValue.Length > 0 ? ddlState.SelectedValue : null; ;
                _account.ZipCode = txtZip.Text.Trim().Length > 0 ? txtZip.Text.Trim() : null;
                _account.Phone = txtPhone.Text.Trim().GetNumbers().Length > 0 ? txtPhone.Text.Trim().GetNumbers() : null;
                _account.IsActive = true;
                _account.MainContact = txtMainContact.Text.Trim().Length > 0 ? txtMainContact.Text.Trim() : null;
                _account.Notes = txtNotes.Text.Trim().Length > 0 ? txtNotes.Text.Trim() : null;

                if (_account.IsNew)
                {
                    _serviceLocation = new ServiceLocationEntity();
                    _serviceLocation.Account = _account;
                }

                _serviceLocation.Name = _account.Name;
                _serviceLocation.Address1 = _account.Address1;
                _serviceLocation.Address2 = _account.Address2;
                _serviceLocation.City = _account.City;
                _serviceLocation.ZipCode = _account.ZipCode;
                _serviceLocation.MainContact = _account.MainContact;
                _serviceLocation.Notes = _account.Notes;
                _serviceLocation.Phone = _account.Phone;
                _serviceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly;

                _account.Save();
                _serviceLocation.Save();

                Response.Redirect("~/EditAssetReclamationAccount.aspx?acctId=" + _account.AccountId.ToString());
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssetReclamationAccounts.aspx");
        }

        protected void btnSaveAssetTypePrices_Click(object sender, EventArgs e)
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
                        int serviceLocationAssetTypeId = Convert.ToInt32(assetTypeValues["ServiceLocationAssetTypeId"].ToString());
                        ServiceLocationAssetTypeEntity serviceLocationAssetType = new ServiceLocationAssetTypeEntity(serviceLocationAssetTypeId);

                        TextBox txtPricePerUnit = assetTypeItem.FindControl("txtPricePerUnit") as TextBox;
                        HiddenField hdnOrigPrice = assetTypeItem.FindControl("hdnOrigPrice") as HiddenField;

                        decimal price = 0;
                        decimal origPrice = Convert.ToDecimal(hdnOrigPrice.Value.Trim().Replace("$", ""));

                        if (txtPricePerUnit.Text.Trim().Length > 0)
                            price = Convert.ToDecimal(txtPricePerUnit.Text.Trim().Replace("$", ""));

                        serviceLocationAssetType.PricePerUnit = price;
                        serviceLocationAssetType.Save();

                        if (price != origPrice)
                        {
                            ChangeLogEntity cle = new ChangeLogEntity();
                            cle.UserId = sm.AuthenticatedUser.UserId;
                            cle.ChangeDate = DateTime.Now;
                            cle.ChangeTypeId = (int)ChangeTypeEntity.ChangeTypes.AssetTypePriceChange;
                            cle.Save();
                            ServiceLocationAssetTypeChangeLogEntity slatcle = new ServiceLocationAssetTypeChangeLogEntity();
                            slatcle.ServiceLocationAssetTypeId = serviceLocationAssetType.ServiceLocationAssetTypeId;
                            slatcle.ChangeLog = cle;
                            slatcle.Save();

                        }

                    }
                }
            }

            Response.Redirect("AssetReclamationAccounts.aspx");
        }

        protected void btnCancelAssetTypePrices_Click(object sender, EventArgs e)
        {
            populate();
            rdAssetTypeGrid.Rebind();
        }

        #endregion

        #region RadGrid Events

        #region rdAssetTypeGrid
        protected void rdAssetTypeGrid_OnDataBinding(object source, EventArgs e)
        {

        }

        protected void rdAssetTypeGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridDataItem && !_serviceLocation.IsNew && _serviceLocation != null)
            {
                if (e.Item.OwnerTableView.Name == "AssetTypeView" && _serviceLocation.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly)
                {
                    ServiceLocationAssetTypeEntity assetType = e.Item.DataItem as ServiceLocationAssetTypeEntity;

                    TextBox txtPricePerUnit = e.Item.FindControl("txtPricePerUnit") as TextBox;
                    HiddenField hdnOrigPrice = e.Item.FindControl("hdnOrigPrice") as HiddenField;

                    if (txtPricePerUnit != null)
                    {
                        var serviceLocationAssetType = (from slat in _db.ServiceLocationAssetType
                                                        where slat.AssetTypeId == assetType.AssetTypeId
                                                        && slat.ServiceLocationId == _serviceLocation.ServiceLocationId
                                                        select slat).ToList();

                        if (serviceLocationAssetType.Count() == 0)
                        {
                            ServiceLocationAssetTypeEntity slat = new ServiceLocationAssetTypeEntity();
                            slat.ServiceLocationId = _serviceLocation.ServiceLocationId;
                            slat.AssetTypeId = assetType.AssetTypeId;
                            slat.PricePerUnit = 0;
                            slat.Save();

                            txtPricePerUnit.Text = slat.PricePerUnit.ToString("C");
                        }
                        else
                        {
                            ServiceLocationAssetTypeEntity slat = serviceLocationAssetType.First();
                            txtPricePerUnit.Text = slat.PricePerUnit.ToString("C");
                        }

                        hdnOrigPrice.Value = txtPricePerUnit.Text;
                    }
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

            var serviceLocationAssetTypes = from slat in _db.ServiceLocationAssetType
                                            join at in _db.AssetType on slat.AssetTypeId equals at.AssetTypeId
                                            join ac in _db.AssetCategory on at.AssetCategoryId equals ac.AssetCategoryId
                                            where at.AssetCategoryId == assetCategory.AssetCategoryId
                                            && slat.ServiceLocationId == _serviceLocation.ServiceLocationId
                                            select slat;

            List<ServiceLocationAssetTypeEntity> slats = new List<ServiceLocationAssetTypeEntity>();

            foreach (AssetTypeEntity ate in assetTypes)
            {
                if (serviceLocationAssetTypes.Where(x => x.AssetTypeId == ate.AssetTypeId).Count() > 0)
                    slats.Add(serviceLocationAssetTypes.Where(x => x.AssetTypeId == ate.AssetTypeId).First());
                else
                {
                    ServiceLocationAssetTypeEntity slat = new ServiceLocationAssetTypeEntity();
                    slat.ServiceLocationId = _serviceLocation.ServiceLocationId;
                    slat.AssetTypeId = ate.AssetTypeId;
                    slat.PricePerUnit = 0;
                    slat.Save();
                    slats.Add(slat);
                }
            }

            e.DetailTableView.DataSource = slats.OrderBy(x => x.AssetType.Name);
        }

        #endregion

        #endregion

        #region Repeater Events

        protected void rptChanges_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                ServiceLocationAssetTypeChangeLogEntity dfcl = e.Item.DataItem as ServiceLocationAssetTypeChangeLogEntity;
                Label lblDate = e.Item.FindControl("lblDate") as Label;
                Label lblUsername = e.Item.FindControl("lblUsername") as Label;
                Label lblRevisionInfo = e.Item.FindControl("lblRevisionInfo") as Label;

                lblDate.Text = dfcl.ChangeLog.ChangeDate.ToShortDateString() + " " +
                    dfcl.ChangeLog.ChangeDate.ToLongTimeString();
                lblUsername.Text = dfcl.ChangeLog.User.Username;
                lblRevisionInfo.Text = dfcl.ChangeLog.ChangeType.Description;
            }
        }
        #endregion

    }
}
