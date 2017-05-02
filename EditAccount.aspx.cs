using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using ReliantUtilityLibrary;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Reliant.RenuOil.DAL.Linq;
using System.Text;
using System.IO;
using Telerik.Web.UI;
using System.Collections;

namespace RenuOil
{
    public partial class EditAccount : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private AccountEntity _account = null;
        private ServiceLocationEntity _recycleServiceLocation
        {
            get
            {
                if (Session["recycleServiceLocation"] == null)
                {
                    return null;
                }
                return (ServiceLocationEntity)Session["recycleServiceLocation"];
            }
            set
            {
                Session["recycleServiceLocation"] = value;
            }
        }
        private ServiceLocationEntity _assetReclamationServiceLocation
        {
            get
            {
                if (Session["assetReclamationServiceLocation"] == null)
                {
                    return null;
                }
                return (ServiceLocationEntity)Session["assetReclamationServiceLocation"];
            }
            set
            {
                Session["assetReclamationServiceLocation"] = value;
            }
        }
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
        protected void Page_Init(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser == null)
                Response.Redirect("~/Default.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int acctId = 0;
            int.TryParse(Request.QueryString["acctId"], out acctId);
            string type = Request.QueryString["type"];

            if (acctId > 0)
            {
                _account = new AccountEntity(acctId);
                btnAddNewOutlet.Visible = true;
                instructions.Visible = false;
            }
            else
            {
                _account = new AccountEntity();
                btnAddNewOutlet.Visible = false;
            }

            if (!Page.IsPostBack)
            {
                populate();
            }

        }

        #endregion

        #region Methods

        private void populate()
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

                var serviceLocations = from sl in _db.ServiceLocation
                                       where sl.AccountId == _account.AccountId
                                       && sl.IsActive == true
                                       orderby sl.Name
                                       select sl;

                var oilFiltrationServiceLocations = serviceLocations.Where(s => s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly).ToList().OrderBy(l => l.Ordinal);

                var recycleLocation = serviceLocations.FirstOrDefault(s => s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly);
                var assetReclamationLocation = serviceLocations.FirstOrDefault(s => s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly);
                docks.Visible = true;
                if (recycleLocation != null)
                {
                    _recycleServiceLocation = recycleLocation;
                    //lnkbtnSetupRecycling.Visible = false;
                    recyclingTypes.Visible = true;
                    
                }

                rptRecyclingTypes.Bind(_db.RecycleType.OrderBy(r => r.Name).ToList());
                if (assetReclamationLocation != null)
                {
                    _assetReclamationServiceLocation = assetReclamationLocation;
                    //lnkSetupAsset.Visible = false;
                    assetFiltrationConfiguration.Visible = true;
                }

                blServiceLocations.Items.Clear();
                //foreach (ServiceLocationEntity sle in oilFiltrationServiceLocations)
                //{
                //    blServiceLocations.Items.Add(new ListItem(sle.Name, "EditServiceLocation.aspx?id=" + sle.ServiceLocationId.ToString()));
                //}
                rgServiceLocations.DataSource = oilFiltrationServiceLocations;
                blServiceLocations.DisplayMode = BulletedListDisplayMode.HyperLink;

                var revisions = from slatcl in _db.ServiceLocationAssetTypeChangeLog
                                join slat in _db.ServiceLocationAssetType on slatcl.ServiceLocationAssetTypeId equals slat.ServiceLocationAssetTypeId
                                join s in _db.ServiceLocation on slat.ServiceLocationId equals s.ServiceLocationId
                                where s.AccountId == _account.AccountId
                                && s.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                                orderby slatcl.ChangeLog.ChangeDate descending
                                select slatcl;

                if (revisions.Count() > 0)
                {
                    rptChanges.DataSource = revisions.OrderByDescending(x => x.ChangeLog.ChangeDate);
                    rptChanges.DataBind();
                }
                rdAssetTypeGrid.Rebind();
                //rgAssetDocks.Rebind();
                rgRecyclingDocks.Rebind();

                multiView.ActiveViewIndex = 0;
            }
            else
            {
                accountNameTitle.InnerText = "Add New Account:";
                txtAcctName.Focus();
            }
        }

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
        #endregion

        #region Control Events
        protected void lnkSetupAsset_Click(object sender, EventArgs e)
        {
            if (_account != null)
            {
                // create service location
                _assetReclamationServiceLocation = new ServiceLocationEntity();
                _assetReclamationServiceLocation.Account = _account;
                //_assetReclamationServiceLocation.Name = "Primary Dock";
                _assetReclamationServiceLocation.Name = _account.Name;
                _assetReclamationServiceLocation.Address1 = _account.Address1;
                _assetReclamationServiceLocation.Address2 = _account.Address2;
                _assetReclamationServiceLocation.City = _account.City;
                _assetReclamationServiceLocation.ZipCode = _account.ZipCode;
                _assetReclamationServiceLocation.MainContact = _account.MainContact;
                _assetReclamationServiceLocation.Notes = _account.Notes;
                _assetReclamationServiceLocation.Phone = _account.Phone;
                _assetReclamationServiceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly;
                _assetReclamationServiceLocation.Save();
                _account.Save();
                populate();
                assetFiltrationConfiguration.Visible = true;
            }
            else
            {
                messages.AddInfoDiv("After you save the account will you be able to setup the asset reclamation");
            }
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

            messages.AddSuccessDiv("Asset types successfully saved");
        }

        protected void btnCancelAssetTypePrices_Click(object sender, EventArgs e)
        {
            populate();
            rdAssetTypeGrid.Rebind();
        }

        protected void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string errorMessage = validate();

            if (errorMessage.Length == 0)
            {
                bool isNew = _account.IsNew;

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
                _account.Save();

                var i = 0;
                foreach (var item in ((IEnumerable<ServiceLocationEntity>)rgServiceLocations.DataSource))
                {
                    item.Ordinal = i++;
                    item.Save();
                }

                if (isNew)
                {
                    _assetReclamationServiceLocation = new ServiceLocationEntity();
                    _assetReclamationServiceLocation.Account = _account;
                    //_assetReclamationServiceLocation.Name = "Primary Dock";
                    _assetReclamationServiceLocation.Name = _account.Name;
                    _assetReclamationServiceLocation.Address1 = _account.Address1;
                    _assetReclamationServiceLocation.Address2 = _account.Address2;
                    _assetReclamationServiceLocation.City = _account.City;
                    _assetReclamationServiceLocation.ZipCode = _account.ZipCode;
                    _assetReclamationServiceLocation.MainContact = _account.MainContact;
                    _assetReclamationServiceLocation.Notes = _account.Notes;
                    _assetReclamationServiceLocation.Phone = _account.Phone;
                    _assetReclamationServiceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly;
                    _assetReclamationServiceLocation.Save();

                    // create service location
                    _recycleServiceLocation = new ServiceLocationEntity();
                    _recycleServiceLocation.Account = _account;
                    _recycleServiceLocation.Name = "Primary Dock";
                    _recycleServiceLocation.Address1 = _account.Address1;
                    _recycleServiceLocation.Address2 = _account.Address2;
                    _recycleServiceLocation.City = _account.City;
                    _recycleServiceLocation.ZipCode = _account.ZipCode;
                    _recycleServiceLocation.MainContact = _account.MainContact;
                    _recycleServiceLocation.Notes = _account.Notes;
                    _recycleServiceLocation.Phone = _account.Phone;
                    _recycleServiceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.RecycleOnly;
                    _recycleServiceLocation.Save();
                }

                Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
            }
            else
            {
                messages.Controls.Add(HtmlHelper.Div("error", errorMessage));
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Accounts.aspx");
        }

        protected void btnAddNewOutlet_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditServiceLocation.aspx?serviceLocationId=0&acctId=" + _account.AccountId.ToString() + "&type=" + ((int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly).ToString());
        }

        protected void changeToAssetReclamationView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 1;
            if (!lnkBtnAssetReclamation.CssClass.Contains("selected"))
                lnkBtnAssetReclamation.CssClass += " selected";
            lnkBtnRecycling.CssClass = lnkBtnRecycling.CssClass.Replace(" selected", "");
            lnkBtnOilFiltration.CssClass = lnkBtnOilFiltration.CssClass.Replace(" selected", "");
            linkBtnDocks.CssClass = linkBtnDocks.CssClass.Replace(" selected", "");
        }

        protected void changeToOilFiltrationView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 0;
            if (!lnkBtnOilFiltration.CssClass.Contains("selected"))
                lnkBtnOilFiltration.CssClass += " selected";
            lnkBtnRecycling.CssClass = lnkBtnRecycling.CssClass.Replace(" selected", "");
            lnkBtnAssetReclamation.CssClass = lnkBtnAssetReclamation.CssClass.Replace(" selected", "");
            linkBtnDocks.CssClass = linkBtnDocks.CssClass.Replace(" selected", "");
        }

        protected void changeToRecyclingView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 2;
            if (!lnkBtnRecycling.CssClass.Contains("selected"))
                lnkBtnRecycling.CssClass += " selected";
            lnkBtnOilFiltration.CssClass = lnkBtnOilFiltration.CssClass.Replace(" selected", "");
            lnkBtnAssetReclamation.CssClass = lnkBtnAssetReclamation.CssClass.Replace(" selected", "");
            linkBtnDocks.CssClass = linkBtnDocks.CssClass.Replace(" selected", "");
        }
        protected void changeToDockView(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 3;
            if (!linkBtnDocks.CssClass.Contains("selected"))
                linkBtnDocks.CssClass += " selected";
            lnkBtnOilFiltration.CssClass = lnkBtnOilFiltration.CssClass.Replace(" selected", "");
            lnkBtnAssetReclamation.CssClass = lnkBtnAssetReclamation.CssClass.Replace(" selected", "");
            lnkBtnRecycling.CssClass = lnkBtnRecycling.CssClass.Replace(" selected", "");
        }
        protected void lnkbtnSetupRecycling_Click(object sender, EventArgs e)
        {
            if (_account != null)
            {
                // create service location
                _recycleServiceLocation = new ServiceLocationEntity();
                _recycleServiceLocation.Account = _account;
                _recycleServiceLocation.Name = "Primary Dock";
                _recycleServiceLocation.Address1 = _account.Address1;
                _recycleServiceLocation.Address2 = _account.Address2;
                _recycleServiceLocation.City = _account.City;
                _recycleServiceLocation.ZipCode = _account.ZipCode;
                _recycleServiceLocation.MainContact = _account.MainContact;
                _recycleServiceLocation.Notes = _account.Notes;
                _recycleServiceLocation.Phone = _account.Phone;
                _recycleServiceLocation.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.RecycleOnly;
                _recycleServiceLocation.Save();
                _account.Save();
                populate();
                recyclingTypes.Visible = true;
            }
            else
            {
                messages.AddInfoDiv("After you save the account will you be able to setup the asset reclamation");
            }
        }

        protected void btnSaveRecycleTypes_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in rptRecyclingTypes.Items)
            {
                var id = Convert.ToInt32(((Label)item.FindControl("lblRecyclingTypeId")).Text);
                var checkbox = (CheckBox)item.FindControl("cbRecycleTypeSelected");
                var option = _db.ServiceLocationRecycleType.FirstOrDefault(s => s.ServiceLocationId == _recycleServiceLocation.ServiceLocationId && s.RecycleTypeId == id);
                if (checkbox.Checked)
                {
                    if (option == null)
                    {
                        // not selected before, create one
                        ServiceLocationRecycleTypeEntity slr = new ServiceLocationRecycleTypeEntity();
                        slr.ServiceLocationId = _recycleServiceLocation.ServiceLocationId;
                        slr.RecycleTypeId = id;
                        slr.IsActive = true;
                        slr.Save();
                    }
                    else
                    {
                        // make sure it's checked
                        option.IsActive = true;
                        option.Save();
                    }
                }
                else
                {
                    if (option != null)
                    {
                        // make sure it's deselected
                        option.IsActive = false;
                        option.Save();
                    }
                }
            }
            messages.AddSuccessDiv("Recycling types successfully saved");
        }

        protected void btnAddNewDock_Click(object sender, EventArgs e)
        {
            //divAddNewAssetDock.Visible = true;
            //hdnAssetDockId.Value = "0";
            //txtAssetDockName.Text = "";
            //btnSaveAssetDock.Visible = false;
        }

        protected void btnSaveAssetDock_Click(object sender, EventArgs e)
        {
            //if (txtAssetDockName.Text.Trim().Length > 0)
            //{
            //    var dock = new ServiceLocationEntity(Convert.ToInt32(hdnAssetDockId.Value));
            //    dock.Name = txtAssetDockName.Text;
            //    dock.AccountId = _account.AccountId;
            //    dock.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly;
            //    dock.Save();
            //    rgAssetDocks.Rebind();
            //    divAddNewAssetDock.Visible = false;
            //}
        }

        protected void btnSaveAssetDocks_Click(object sender, EventArgs e)
        {
            //foreach (GridDataItem item in rgAssetDocks.Items)
            //{
            //    TextBox txtAssetDockName = item.FindControl("txtAssetDockName") as TextBox;
            //    HiddenField dockId = item.FindControl("hdnAssetDockId") as HiddenField;

            //    if (dockId != null)
            //    {
            //        ServiceLocationEntity dock = new ServiceLocationEntity(Convert.ToInt32(dockId.Value));
            //        dock.Name = txtAssetDockName.Text;
            //        dock.Save();
            //    }
            //}

            //Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());

        }

        protected void btnAddNewAssetDock_Click(object sender, EventArgs e)
        {
            //divAddNewAssetDock.Visible = true;
        }

        protected void btnCancelAssetDocks_Click(object sender, EventArgs e)
        {
            //populate();
            //rgAssetDocks.Rebind();
            //divAddNewAssetDock.Visible = false;
            //txtAssetDockName.Text = "";
            //hdnAssetDockId.Value = "0";

            //Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }

        protected void btnAddNewRecyclingDock_Click(object sender, EventArgs e)
        {
            divRecyclingDockDetails.Visible = true;
            hdnRecyclingDockId.Value = "0";
            txtRecylingDockName.Text = "";
            btnSaveRecyclingDocks.Visible = false;
        }

        protected void btnSaveRecyclingDock_Click(object sender, EventArgs e)
        {
            if (txtRecylingDockName.Text.Trim().Length > 0)
            {
                var dock = new ServiceLocationEntity(Convert.ToInt32(hdnRecyclingDockId.Value));
                dock.Name = txtRecylingDockName.Text;
                dock.AccountId = _account.AccountId;
                dock.ServiceTypeId = (int)ServiceTypeEntity.ServiceTypes.RecycleOnly;
                dock.Save();
                rgRecyclingDocks.Rebind();
                divRecyclingDockDetails.Visible = false;
            }
        }

        protected void btnSaveRecyclingDocks_Click(object sender, EventArgs e)
        {
            foreach (GridDataItem item in rgRecyclingDocks.Items)
            {
                TextBox txtRecylingDockName = item.FindControl("txtRecyclingDockName") as TextBox;
                HiddenField dockId = item.FindControl("hdnRecyclingDockId") as HiddenField;

                if (dockId != null)
                {
                    ServiceLocationEntity dock = new ServiceLocationEntity(Convert.ToInt32(dockId.Value));
                    dock.Name = txtRecylingDockName.Text;
                    dock.Save();
                }
            }

            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());

        }

        protected void btnCancelRecyclingDocks_Click(object sender, EventArgs e)
        {
            populate();
            rgRecyclingDocks.Rebind();
            divRecyclingDockDetails.Visible = false;
            txtRecylingDockName.Text = "";
            hdnRecyclingDockId.Value = "0";

            Response.Redirect("~/EditAccount.aspx?acctId=" + _account.AccountId.ToString());
        }
        #endregion

        #region ListView Events
        protected void lstViewServiceLocations_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                //ServiceLocationEntity serviceLocation = e.Item.DataItem as ServiceLocationEntity;

                // LinkButton lnkBtnEditServiceLocation = e.Item.FindControl("lnkBtnEditServiceLocation") as LinkButton;
                //Label lblAddress = e.Item.FindControl("lblAddress") as Label;
                //Label lblPhone = e.Item.FindControl("lblPhone") as Label;
                //Label lblNumOfFryers = e.Item.FindControl("lblNumOfFryers") as Label;
                //Label lblAssetRecovery = e.Item.FindControl("lblAssetRecovery") as Label;
                //Label lblRecycleService = e.Item.FindControl("lblRecycleService") as Label;

                //lnkBtnEditServiceLocation.Text = serviceLocation.Name;
                //string address = "";

                //if (serviceLocation.Address1 != null && serviceLocation.Address1.Length > 0)
                //{
                //    address = serviceLocation.Address1;
                //}
                //if (serviceLocation.Address2 != null && serviceLocation.Address2.Length > 0)
                //    address += ", " + serviceLocation.Address2;
                //if (serviceLocation.City != null && serviceLocation.City.Length > 0)
                //    address += " " + serviceLocation.City;
                //if (serviceLocation.State != null && serviceLocation.State.Length > 0)
                //    address += ", " + serviceLocation.State;
                //else if (serviceLocation.IntlState != null && serviceLocation.IntlState.Length > 0)
                //    address += ", " + serviceLocation.IntlState;
                //if (serviceLocation.ZipCode != null && serviceLocation.ZipCode.Length > 0)
                //    address += " " + serviceLocation.ZipCode;

                //lblAddress.Text = address;

                ////if (serviceLocation.Phone != null)
                ////    lblPhone.Text = serviceLocation.Phone;

                //int numOfFryers = _db.DeepFryer.Where(x => x.ServiceLocationId == serviceLocation.ServiceLocationId).ToList().Count();
                //if (numOfFryers >= 0 && serviceLocation.FryerService == true)

                //    lblNumOfFryers.Text = numOfFryers.ToString();
                //else
                //    lblNumOfFryers.Text = "N/A";

                //lblAssetRecovery.Text = _account.ServiceLocation.Where(x => x.AssetReclamationService == true).Count() > 0 ? "Yes" : "No";
                //lblRecycleService.Text = _account.ServiceLocation.Where(x => x.RecycleService == true).Count() > 0 ? "Yes" : "No";
            }
        }

        protected void lstViewServiceLocations_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditServiceLocation.aspx?serviceLocationId=" + e.CommandArgument.ToString() + "&tab=0");
                    break;

                case "Delete":
                    break;

                default:
                    break;

            }
        }
        #endregion

        #region RadGrid Events

        #region rgAssetDocks
        
        protected void rgAssetDocks_OnItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    HiddenField hdnAssetDockId = e.Item.FindControl("hdnAssetDockId") as HiddenField;

                    if (hdnAssetDockId != null)
                    {
                        ServiceLocationEntity dock = new ServiceLocationEntity(Convert.ToInt32(hdnAssetDockId.Value));
                        dock.IsActive = false;
                        dock.Save();
                    }
                    break;

                default:
                    break;
            }
        }

        protected void rgAssetDocks_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            //if (!e.IsFromDetailTable)
            //{
            //    var docks = from df in _db.ServiceLocation
            //                where df.AccountId == _account.AccountId
            //                && df.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
            //                && df.IsActive == true
            //                orderby df.Name
            //                select df;

            //    rgAssetDocks.DataSource = docks;

            //    var validDockCount = docks.Count() > 0;
            //    rgAssetDocks.Visible = validDockCount;
            //    btnSaveAssetDocks.Visible = validDockCount;
            //    btnCancelAssetDocks.Visible = validDockCount;
            //}
        }

        #endregion

        #region rdAssetTypeGrid
        protected void rdAssetTypeGrid_OnDataBinding(object source, EventArgs e)
        {

        }

        protected void rdAssetTypeGrid_OnItemDataBound(object sender, GridItemEventArgs e)
        {
            if (_assetReclamationServiceLocation != null)
            {
                if (e.Item is GridDataItem && !_assetReclamationServiceLocation.IsNew)
                {
                    if (e.Item.OwnerTableView.Name == "AssetTypeView" && _assetReclamationServiceLocation.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.AssetReclamationOnly)
                    {
                        ServiceLocationAssetTypeEntity assetType = e.Item.DataItem as ServiceLocationAssetTypeEntity;

                        TextBox txtPricePerUnit = e.Item.FindControl("txtPricePerUnit") as TextBox;
                        HiddenField hdnOrigPrice = e.Item.FindControl("hdnOrigPrice") as HiddenField;

                        if (txtPricePerUnit != null)
                        {
                            var serviceLocationAssetType = (from slat in _db.ServiceLocationAssetType
                                                            where slat.AssetTypeId == assetType.AssetTypeId
                                                            && slat.ServiceLocationId == _assetReclamationServiceLocation.ServiceLocationId
                                                            select slat).ToList();

                            if (serviceLocationAssetType.Count() == 0)
                            {
                                ServiceLocationAssetTypeEntity slat = new ServiceLocationAssetTypeEntity();
                                slat.ServiceLocationId = _assetReclamationServiceLocation.ServiceLocationId;
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
            else
            {
                rdAssetTypeGrid.DataSource = null;
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
            if (_assetReclamationServiceLocation != null)
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
                                                && slat.ServiceLocationId == _assetReclamationServiceLocation.ServiceLocationId
                                                select slat;

                List<ServiceLocationAssetTypeEntity> slats = new List<ServiceLocationAssetTypeEntity>();

                foreach (AssetTypeEntity ate in assetTypes)
                {
                    if (serviceLocationAssetTypes.Where(x => x.AssetTypeId == ate.AssetTypeId).Count() > 0)
                        slats.Add(serviceLocationAssetTypes.Where(x => x.AssetTypeId == ate.AssetTypeId).First());
                    else
                    {
                        ServiceLocationAssetTypeEntity slat = new ServiceLocationAssetTypeEntity();
                        slat.ServiceLocationId = _assetReclamationServiceLocation.ServiceLocationId;
                        slat.AssetTypeId = ate.AssetTypeId;
                        slat.PricePerUnit = 0;
                        slat.Save();
                        slats.Add(slat);
                    }
                }

                e.DetailTableView.DataSource = slats.OrderBy(x => x.AssetType.Name);
            }
            else
            {
                e.DetailTableView.DataSource = null;
            }
        }

        #endregion

        #region rgRecyclingDocks

        protected void rgRecyclingDocks_OnItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                //case "delete":
                //    HiddenField hdnRecyclingDockId = e.Item.FindControl("hdnRecyclingDockId") as HiddenField;

                //    if (hdnAssetDockId != null)
                //    {
                //        ServiceLocationEntity dock = new ServiceLocationEntity(Convert.ToInt32(hdnRecyclingDockId.Value));
                //        dock.IsActive = false;
                //        dock.Save();
                //    }
                //    break;

                default:
                    break;
            }
        }

        protected void rgRecyclingDocks_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            if (!e.IsFromDetailTable)
            {
                var docks = from df in _db.ServiceLocation
                            where df.AccountId == _account.AccountId
                            && df.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.RecycleOnly
                            && df.IsActive == true
                            orderby df.Name
                            select df;

                rgRecyclingDocks.DataSource = docks;

                var validDockCount = docks.Count() > 0;
                rgRecyclingDocks.Visible = validDockCount;
                btnSaveRecyclingDocks.Visible = validDockCount;
                //btnCancelAssetDocks.Visible = validDockCount;
            }
        }

        protected void btnMoveUp_OnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var locId = int.Parse(btn.CommandArgument);
            var locations = (from sl in _db.ServiceLocation
                             where sl.AccountId == _account.AccountId
                             && sl.IsActive == true && sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                             orderby sl.Ordinal
                             select sl).ToList();

            var ord = 0;
            var i = 0;

            foreach (var item in locations)
            {
                if (item.ServiceLocationId == locId)
                {
                    ord = item.Ordinal.GetValueOrDefault(i);
                    if (ord == 0 && i != 0)
                    {
                        ord = i;
                    }
                    break;
                }
                i++;
            }
            if (ord > 0)
            {
                var list = new List<ServiceLocationEntity>();
                list.AddRange(locations.Take(ord - 2));
                list.Add(locations.Skip(ord - 1).First());
                list.Add(locations.Skip(ord - 2).First());
                list.AddRange(locations.Skip(ord));

                i = 1;
                foreach (var item in list)
                {
                    item.Ordinal = i++;
                    item.Save();
                }
                rgServiceLocations.DataSource = list;
                rgServiceLocations.DataBind();
            }
        }

        protected void btnMoveDown_OnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var locId = int.Parse(btn.CommandArgument);
            var locations = (from sl in _db.ServiceLocation
                             where sl.AccountId == _account.AccountId
                             && sl.IsActive == true && sl.ServiceTypeId == (int)ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                             orderby sl.Ordinal
                             select sl).ToList();

            var ord = 0;
            var i = 0;

            foreach (var item in locations)
            {
                if (item.ServiceLocationId == locId)
                {
                    ord = item.Ordinal.GetValueOrDefault(i);
                    if (ord == 0 && i != 0)
                    {
                        ord = i;
                    }
                    break;
                }
                i++;
            }
            if (ord < locations.Max(l => l.Ordinal))
            {
                var list = new List<ServiceLocationEntity>();
                list.AddRange(locations.Take(ord - 1));
                list.Add(locations.Skip(ord).First());
                list.Add(locations.Skip(ord - 1).First());
                list.AddRange(locations.Skip(ord + 1));

                i = 1;
                foreach (var item in list)
                {
                    item.Ordinal = i++;
                    item.Save();
                }
                rgServiceLocations.DataSource = list;
                rgServiceLocations.DataBind();
            }
        }

        protected void btnEdit_OnClick(object sender, EventArgs e)
        {
            var btn = (LinkButton)sender;
            var locId = int.Parse(btn.CommandArgument);
            Response.Redirect("EditServiceLocation.aspx?id=" + locId);
        }


        #endregion

        #endregion

        #region Repeater Events
        protected void rptServiceLocations_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                ServiceLocationEntity serviceLocation = e.Item.DataItem as ServiceLocationEntity;

                LinkButton lnkBtnEditServiceLocation = e.Item.FindControl("lnkBtnEditServiceLocation") as LinkButton;
                //Label lblAddress = e.Item.FindControl("lblAddress") as Label;
                //Label lblPhone = e.Item.FindControl("lblPhone") as Label;
                //Label lblNumOfFryers = e.Item.FindControl("lblNumOfFryers") as Label;
                //Label lblAssetRecovery = e.Item.FindControl("lblAssetRecovery") as Label;
                //Label lblRecycleService = e.Item.FindControl("lblRecycleService") as Label;

                lnkBtnEditServiceLocation.Text = serviceLocation.Name;
                //string address = "";

                //if (serviceLocation.Address1 != null && serviceLocation.Address1.Length > 0)
                //{
                //    address = serviceLocation.Address1;
                //}
                //if (serviceLocation.Address2 != null && serviceLocation.Address2.Length > 0)
                //    address += ", " + serviceLocation.Address2;
                //if (serviceLocation.City != null && serviceLocation.City.Length > 0)
                //    address += " " + serviceLocation.City;
                //if (serviceLocation.State != null && serviceLocation.State.Length > 0)
                //    address += ", " + serviceLocation.State;
                //else if (serviceLocation.IntlState != null && serviceLocation.IntlState.Length > 0)
                //    address += ", " + serviceLocation.IntlState;
                //if (serviceLocation.ZipCode != null && serviceLocation.ZipCode.Length > 0)
                //    address += " " + serviceLocation.ZipCode;

                //lblAddress.Text = address;

                ////if (serviceLocation.Phone != null)
                ////    lblPhone.Text = serviceLocation.Phone;

                //int numOfFryers = _db.DeepFryer.Where(x => x.ServiceLocationId == serviceLocation.ServiceLocationId).ToList().Count();
                //if (numOfFryers >= 0 && serviceLocation.FryerService == true)

                //    lblNumOfFryers.Text = numOfFryers.ToString();
                //else
                //    lblNumOfFryers.Text = "N/A";

                //lblAssetRecovery.Text = _account.ServiceLocation.Where(x => x.AssetReclamationService == true).Count() > 0 ? "Yes" : "No";
                //lblRecycleService.Text = _account.ServiceLocation.Where(x => x.RecycleService == true).Count() > 0 ? "Yes" : "No";
            }
        }

        protected void rptServiceLocations_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditServiceLocation.aspx?serviceLocationId=" + e.CommandArgument.ToString() + "&tab=0");
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

        protected void rptRecyclingTypes_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (_recycleServiceLocation != null)
            {
                if (e.Item.IsDataItem())
                {
                    var type = ((RecycleTypeEntity)e.Item.DataItem);
                    // check to see if this service location has a current tie to this type
                    var association = _db.ServiceLocationRecycleType.FirstOrDefault(s => s.ServiceLocationId == _recycleServiceLocation.ServiceLocationId && s.RecycleTypeId == type.RecycleTypeId && s.IsActive);
                    if (association != null)
                    {
                        // find the checkbox control and check it
                        var checkbox = (CheckBox)e.Item.FindControl("cbRecycleTypeSelected");
                        checkbox.Checked = true;
                    }
                }
            }
        }
        #endregion
    }
}
