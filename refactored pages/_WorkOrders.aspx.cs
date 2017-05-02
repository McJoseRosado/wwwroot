using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ReliantUtilityLibrary;
using System.Threading;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace RenuOil
{
    public partial class _WorkOrders : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private bool _isCompanyUser = false;
        private List<UserAccountEntity> _userAccounts = new List<UserAccountEntity>();

        protected List<ListItem> Accounts = new List<ListItem>();
        protected List<WorkOrderEntity> OilWorkOrders = new List<WorkOrderEntity>();
        protected List<WorkOrderEntity> RecyclingOrders = new List<WorkOrderEntity>();
        protected List<WorkOrderEntity> AssetOrders = new List<WorkOrderEntity>();

        private SessionManager _sm
        {
            get
            {
                if (Session["SessionManager"] == null)
                {
                    Session["SessionManager"] = new SessionManager();
                }
                return (SessionManager) Session["SessionManager"];
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
                startDate.Value = DateTime.Now.AddDays(-7).ToString("MM/dd/yyyy");
                endDate.Value = DateTime.Now.ToString("MM/dd/yyyy");
                
                populateLists(DateTime.Parse(startDate.Value), DateTime.Parse(endDate.Value)); 
                
                if (_sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
                {
                    _isCompanyUser = true;
                    btnAddNewWorkOrder.Visible = false;
                    _userAccounts = _sm.AuthenticatedUser.UserAccount.ToList();
                }
            }
           
            //look at this chi
            if (Page.IsPostBack)
            {
                //Thread.Sleep(3000);
                //Response.Redirect("EditWorkOrder.aspx?id=0");
                if (_sm.TargetWorkOrderId > 0)
                {
                    int target = _sm.TargetWorkOrderId;
                    _sm.TargetWorkOrderId = 0;
                    Response.Redirect("EditWorkOrder.aspx?id=0");
                }
            }
        }

        protected void OnSearchClick(object sender, EventArgs e)
        {
            populateLists(DateTime.Parse(startDate.Value), 
                DateTime.Parse(endDate.Value), 
                int.Parse(accountSelect.Items[accountSelect.SelectedIndex].Value));
        }

        #endregion

        protected void populateLists(DateTime startDate, DateTime endDate, int? accountId = null)
        {
            OilWorkOrders = new List<WorkOrderEntity>();
            RecyclingOrders = new List<WorkOrderEntity>();
            AssetOrders = new List<WorkOrderEntity>();
            Accounts = new List<ListItem>();

            Accounts.Add(new ListItem()
            {
                Text = "All Accounts",
                Value = "0",
                Selected = true
            });

            foreach (var account in _db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList())
            {
                Accounts.Add(new ListItem()
                {
                    Text = account.Name,
                    Value = account.AccountId.ToString()
                });
            }

            if (accountId.HasValue)
            {
                Accounts.ForEach(a =>
                {
                    if (a.Value == accountId.Value.ToString())
                    {
                        a.Selected = true;
                    }
                    else { a.Selected = false; }
                });
            }

            accountSelect.Items.Clear();
            accountSelect.Items.AddRange(Accounts.ToArray());

            if (!accountId.HasValue || accountId.Value == 0)
            {
                var o = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= startDate
                         && wo.AppointmentDate <= endDate
                         orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                         select wo);

                var r = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.RecycleOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= startDate
                         && wo.AppointmentDate <= endDate
                         orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                         select wo);

                var asset = (from wo in _db.WorkOrder
                             join a in _db.Account on wo.AccountId equals a.AccountId
                             where a.IsActive == true
                             && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                             && wo.IsActive == true
                             && wo.AppointmentDate >= startDate
                             && wo.AppointmentDate <= endDate
                             orderby a.Name, wo.AppointmentDate, wo.AppointmentTime
                             select wo);

                OilWorkOrders = o.ToList();
                RecyclingOrders = r.ToList();
                AssetOrders = asset.ToList();
            }
            else
            {
                int selectedAccountId = Convert.ToInt32(accountId.Value);

                var o = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && a.AccountId == selectedAccountId
                         && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.DeepFryerOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= startDate
                         && wo.AppointmentDate <= endDate
                         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                         select wo);

                var r = (from wo in _db.WorkOrder
                         join a in _db.Account on wo.AccountId equals a.AccountId
                         where a.IsActive == true
                         && a.AccountId == selectedAccountId
                         && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.RecycleOnly
                         && wo.IsActive == true
                         && wo.AppointmentDate >= startDate
                         && wo.AppointmentDate <= endDate
                         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                         select wo);

                var asset = (from wo in _db.WorkOrder
                             join a in _db.Account on wo.AccountId equals a.AccountId
                             where a.IsActive == true
                             && a.AccountId == selectedAccountId
                             && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.AssetReclamationOnly
                             && wo.IsActive == true
                             && wo.AppointmentDate >= startDate
                             && wo.AppointmentDate <= endDate
                             orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                             select wo);

                OilWorkOrders = o.ToList();
                RecyclingOrders = r.ToList();
                AssetOrders = asset.ToList();
            }

            if (_isCompanyUser)
            {
                OilWorkOrders = (from wo in OilWorkOrders
                                 join ua in _userAccounts on wo.AccountId equals ua.AccountId
                                 select wo).ToList();

                RecyclingOrders = (from wo in RecyclingOrders
                                   join ua in _userAccounts on wo.AccountId equals ua.AccountId
                                   select wo).ToList();

                AssetOrders = (from wo in AssetOrders
                               join ua in _userAccounts on wo.AccountId equals ua.AccountId
                               select wo).ToList();
            }
        }

        [WebMethod]
        public static string lnkBtnEditWorkOrderBtnCommand(string commandName, int id, string activeTabName)
        {
            var ser = new JavaScriptSerializer();
            var result = "";
            switch (commandName)
            {
                case "Edit":
                    result= "EditWorkOrder.aspx?id=" + id;

                    //deepfryer
                    if (activeTabName == "Oil Filtration")
                    {
                        result = "EditOilFiltrationWorkOrder.aspx?id=" + id;
                    }

                    break;
                case "Delete":
                    WorkOrderEntity workOrder = new WorkOrderEntity(id);
                    workOrder.IsActive = false;
                    workOrder.Save();
                    break;
                default:
                    break;

            }
            return ser.Serialize(new { Success = true, Path = result });
        }

    }
}
