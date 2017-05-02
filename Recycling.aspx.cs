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

namespace RenuOil
{
    public partial class Recycling : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private bool _isAdminUser = false;
        private List<UserAccountEntity> _userAccounts = new List<UserAccountEntity>();

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
                rdFromDate.SelectedDate = DateTime.Now.AddDays(-7);
                rdToDate.SelectedDate = DateTime.Now;

                multiView.ActiveViewIndex = 0;
            }

            if (_sm.AuthenticatedUser.UserTypeId == (int) UserTypeEntity.UserTypes.CompanyUser || _sm.AuthenticatedUser.UserTypeId == (int) UserTypeEntity.UserTypes.Administrator)
            {
                _isAdminUser = true;
                _userAccounts = _sm.AuthenticatedUser.UserAccount.ToList();
            }
        }
        #endregion

        protected void populateLists()
        {

            var r = (from a in _db.Account
                     join wo in _db.WorkOrder on a.AccountId equals wo.AccountId
                     join wos in _db.WorkOrderServiceLocation on wo.WorkOrderId equals wos.WorkOrderId
                     join rs in _db.RecycleService on wos.WorkOrderServiceLocationId equals rs.WorkOrderServiceLocationId
                     where a.IsActive == true
                     && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.RecycleOnly
                     && wo.IsActive == true
                     && wo.AppointmentDate.Date >= rdFromDate.SelectedDate.Value
                     && wo.AppointmentDate.Date <= rdToDate.SelectedDate.Value
                     orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                     select a);

            var recyclingOrders = r.ToList();

            if (recyclingOrders.Count() == 0)
            {
                messages.AddNoticeDiv("No results");
            }
            else
            {
                if (_isAdminUser)
                {
                    rptRecyclingWorkOrders.DataSource = recyclingOrders;
                }

                rptRecyclingWorkOrders.DataBind();
            }
        }



        #region Control Events

        protected void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditRecycling.aspx?id=0");
        }

        protected void btnUpdateWorkOrderList_Click(object sender, EventArgs e)
        {
            populateLists();
        }

        #endregion

        #region Work Orders
        protected void rptWorkOrders_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                AccountEntity account = e.Item.DataItem as AccountEntity;
                Label lblAccountName = e.Item.FindControl("lblAccountName") as Label;
                Repeater workOrderRepeater = e.Item.FindControl("rptAcctWorkOrders") as Repeater;

                var workOrders = (from wo in _db.WorkOrder
                                  join a in _db.Account on wo.AccountId equals a.AccountId
                                  join wos in _db.WorkOrderServiceLocation on wo.WorkOrderId equals wos.WorkOrderId
                                  join r in _db.RecycleService on wos.WorkOrderServiceLocationId equals r.WorkOrderServiceLocationId
                                  where a.IsActive == true
                                  && wo.ServiceTypeId == (int) ServiceTypeEntity.ServiceTypes.RecycleOnly
                                  && wo.IsActive == true
                                  && wo.AppointmentDate.Date >= rdFromDate.SelectedDate.Value
                                  && wo.AppointmentDate.Date <= rdToDate.SelectedDate.Value
                                  && wo.AccountId == account.AccountId
                                  orderby wo.AppointmentDate, wo.AppointmentTime, a.Name descending
                                  select wo);

                workOrderRepeater.DataSource = workOrders;
                workOrderRepeater.DataBind();

                lblAccountName.Text = account.Name;
            }
        }

        protected void rptWorkOrders_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            int workOrderId = Convert.ToInt32(e.CommandArgument.ToString());

            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditWorkOrder.aspx?id=" + e.CommandArgument.ToString());
                    break;

                case "Delete":
                    WorkOrderEntity workOrder = new WorkOrderEntity(workOrderId);
                    workOrder.IsActive = false;
                    workOrder.Save();

                    populateLists();
                    //var q = (from wo in _db.WorkOrder
                    //         join a in _db.Account on wo.AccountId equals a.AccountId
                    //         where a.IsActive == true
                    //         && wo.IsActive == true
                    //         orderby wo.AppointmentDate, wo.AppointmentTime, a.Name
                    //         select wo);
                    ////if (!chkShowCompleted.Checked) q = q.Where(x => !x.IsComplete);
                    //var workOrders = q.ToList();

                    //rptOilFiltrationWorkOrders.DataSource = workOrders;
                    //rptOilFiltrationWorkOrders.DataBind();

                    break;

                default:
                    break;

            }
        }

        protected void lstViewWorkOrders_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
            ListViewDataItem dataItem = (ListViewDataItem) e.Item;

            Label lblAppointmentDate = dataItem.FindControl("lblAppointmentDate") as Label;
        }

        protected void rptAcctWorkOrders_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                WorkOrderEntity workOrder = e.Item.DataItem as WorkOrderEntity;

                Label lblAppointmentDate = e.Item.FindControl("lblAppointmentDate") as Label;
                Label lblActionType = e.Item.FindControl("lblActionType") as Label;
                string time = workOrder.AppointmentTime.HasValue ? workOrder.AppointmentTime.Value.ToShortTimeString() : "";

                lblAppointmentDate.Text = workOrder.AppointmentDate.ToShortDateString() + " " + time;
                WorkOrderServiceLocationEntity wsle = workOrder.WorkOrderServiceLocation.First();

                var recycleservice = from r in _db.RecycleService
                                     where r.WorkOrderServiceLocationId == wsle.WorkOrderServiceLocationId
                                     select r;

                
                if (recycleservice.Count() > 0)
                {
                    var recycleserviceAction = from ra in _db.RecycleServiceAction
                                               where ra.RecycleServiceId == recycleservice.First().RecycleServiceId
                                               select ra;
                    if (recycleserviceAction.Count() > 0)
                    {
                        RecycleServiceActionEntity ra = recycleserviceAction.First();
                        lblActionType.Text = ra.ActionType;
                        //var bales = ra.Bale.ToList();

                    }
                }

            }
        }

        protected void rptAcctWorkOrders_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {

        }


        #endregion

    }
}