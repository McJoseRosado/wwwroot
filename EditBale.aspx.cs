using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class EditBale : System.Web.UI.Page
    {
        protected SessionManager sm
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

        protected List<BaleEntity> Bales = new List<BaleEntity>();
        protected List<DockEntity> Docks = new List<DockEntity>();
        protected List<RecycleTypeEntity> RecycleTypesList = new List<RecycleTypeEntity>();
        protected List<AccountEntity> Properties = new List<AccountEntity>();

        private static LinqMetaData _db = new LinqMetaData();

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC3.aspx");
        }

        protected void OnSearchClick(object sender, EventArgs e)
        {
            Bales = _db.Bale.Where(l =>
                l.CreatedDate.Date >= DateTime.Parse(startDate.Value)
                && l.CreatedDate.Date <= DateTime.Parse(endDate.Value)
                && l.IsActive).ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //get all lists
            Properties = _db.Account.Where(ee => ee.IsActive).OrderBy(a => a.Name).ToList();
            RecycleTypesList = _db.RecycleType.Where(ee => ee.IsActive).OrderBy(a => a.Name).ToList();
            Docks = _db.Dock.Where(ee => ee.IsActive).ToList();

            if (!IsPostBack)
            {
                //default to today and yesterday
                startDate.Value = DateTime.Today.AddDays(-1).Date.ToString("MM/dd/yyyy");
                endDate.Value = DateTime.Today.Date.ToString("MM/dd/yyyy");

                Bales = _db.Bale.Where(l =>
                    l.CreatedDate.Date >= DateTime.Parse(startDate.Value)
                    && l.CreatedDate.Date <= DateTime.Parse(endDate.Value)
                    && l.IsActive).ToList();
            }
        }

        [WebMethod]
        public static string Save(int baleId, int accountId, int dockId, int recycleTypeId, int baleNumber, string notes, int initWeight)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var bale = _db.Bale.ToList().FirstOrDefault(d => d.BaleId == baleId);
                if (bale != null)
                {
                    bale.AccountId = accountId;
                    bale.DockId = dockId;
                    bale.RecycleTypeId = recycleTypeId;
                    bale.BaleNumber = baleNumber;
                    bale.Notes = notes;
                    bale.InitWeight = initWeight;

                    bale.Save();
                }
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }

        [WebMethod]
        public static string Delete(int baleId)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var bale = _db.Bale.ToList().FirstOrDefault(d => d.BaleId == baleId);
                if (bale != null)
                {
                    bale.IsActive = false;
                    bale.Save();
                }
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }
    }
}