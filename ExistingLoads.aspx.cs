using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class ExistingLoad : System.Web.UI.Page
    {
        protected List<LoadEntity> Loads;
        protected List<EmployeeEntity> Drivers;
        protected List<BaleEntity> Bales;

        private static LinqMetaData _db = new LinqMetaData();

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Drivers = _db.Employee.OrderBy(d => d.LastName).ToList();
                Bales = _db.Bale.OrderBy(b => b.BaleId).ToList();

                startDate.Value = DateTime.Today.AddDays(-1).Date.ToString("MM/dd/yyyy");
                endDate.Value = DateTime.Today.Date.ToString("MM/dd/yyyy");

                Loads = _db.Load.Where(
                    l => l.Date.Date >= DateTime.Parse(startDate.Value).Date
                    && l.Date.Date <= DateTime.Parse(endDate.Value).Date
                    && l.IsActive).OrderBy(l => l.Date.Date).ThenBy(l => l.EmployeeId).ToList();
            }
        }
        
        //Mar 3, 2016
        //Chi - No edit function after the new layout
        [WebMethod]
        public static string Save(int loadId, string date, int driverId, string selectedBaleIds, string deselectedBaleIds)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var load = _db.Load.ToList().FirstOrDefault(d => d.LoadId == loadId);
                if (load != null)
                {
                    load.Date = DateTime.Parse(date);
                    load.EmployeeId = driverId;

                    load.Save();

                    var selectedBalesIds = ser.Deserialize<List<int>>(selectedBaleIds);
                    foreach (var balesId in selectedBalesIds)
                    {
                        var bale = _db.Bale.FirstOrDefault(b => b.BaleId == balesId);
                        if (bale != null)
                        {
                            bale.LoadId = loadId;
                            bale.Save();
                        }
                    }

                    var deselectedBalesIds = ser.Deserialize<List<int>>(deselectedBaleIds);
                    foreach (var balesId in deselectedBalesIds)
                    {
                        var bale = _db.Bale.FirstOrDefault(b => b.BaleId == balesId && b.LoadId == loadId);
                        if (bale != null)
                        {
                            bale.LoadId = null;
                            bale.Save();
                        }
                    }
                }
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }

        [WebMethod]
        public static string Delete(int loadId)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var load = _db.Load.ToList().FirstOrDefault(d => d.LoadId == loadId);
                if (load != null)
                {
                    var attachedBales = _db.Bale.Where(b => b.LoadId == load.LoadId).ToList();
                    foreach (var bale in attachedBales)
                    {
                        bale.LoadId = null;
                        bale.Save();
                    }

                    load.IsActive = false;
                    load.Save();
                }
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }

        protected void OnSearchClick(object sender, EventArgs e)
        {
            Loads = _db.Load.Where(
                    l => l.Date.Date >= DateTime.Parse(startDate.Value).Date
                    && l.Date.Date <= DateTime.Parse(endDate.Value).Date
                    && l.IsActive).OrderBy(l => l.EmployeeId).ThenBy(l => l.Date.Date).ToList();
        }
    }
}