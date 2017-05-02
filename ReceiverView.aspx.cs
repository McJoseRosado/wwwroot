using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.DataHelperClasses;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;
using ReliantUtilityLibrary;

namespace RenuOil
{
    public partial class ReceiverView : System.Web.UI.Page
    {
        protected List<LoadEntity> Loads;
        protected List<EmployeeEntity> Drivers;
        protected List<BaleEntity> Bales;
        protected List<AccountEntity> Properties = new List<AccountEntity>();
        protected List<RecycleTypeEntity> RecycleTypesList = new List<RecycleTypeEntity>();

        private static LinqMetaData _db = new LinqMetaData();

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC.aspx");
        }

        protected void OnSearchClick(object sender, EventArgs e)
        {
            Loads = _db.Load.Where(l =>
                l.Date.Date >= DateTime.Parse(startDate.Value)
                && l.Date.Date <= DateTime.Parse(endDate.Value)
                && l.IsActive).ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Drivers = _db.Employee.Where(ee => ee.IsActive).OrderBy(d => d.LastName).ToList();
            Bales = _db.Bale.Where(b => b.IsActive).OrderBy(b => b.BaleId).ToList();
            Properties = _db.Account.Where(ee => ee.IsActive).OrderBy(a => a.Name).ToList();
            RecycleTypesList = _db.RecycleType.Where(r => r.IsActive).OrderBy(a => a.Name).ToList();

            if (!IsPostBack)
            {
                //default to today and yesterday
                startDate.Value = DateTime.Today.AddDays(-1).Date.ToString("MM/dd/yyyy");
                endDate.Value = DateTime.Today.Date.ToString("MM/dd/yyyy");

                Loads = _db.Load.Where(
                        l => l.Date.Date >= DateTime.Parse(startDate.Value)
                        && l.Date.Date <= DateTime.Parse(endDate.Value)
                        && l.IsActive).ToList();
            }
        }

        [WebMethod]
        public static string GetBales(int loadId)
        {
            var ser = new JavaScriptSerializer();
            var bales = new List<BaleEntityData>();

            try
            {
                _db.Bale.Where(d => d.LoadId == loadId && 
                    d.IsActive).ForEach(dd =>
                {
                    bales.Add(BaleEntityData.BaleEntityToData(dd));
                });

                return ser.Serialize(new { Success = true, Bales = bales });
            }
            catch
            {
                return ser.Serialize(new { Success = false, Bales = bales });
            }
        }

        [WebMethod]
        public static string GetRecycleTypesList()
        {
            var ser = new JavaScriptSerializer();
            var recycleTypes = new List<RecycleTypeEntityData>();

            try
            {
                _db.RecycleType.Where(r => r.IsActive).OrderBy(r => r.Name).ToList().ForEach(dd =>
                {
                    recycleTypes.Add(RecycleTypeEntityData.RecycleTypeEntityToData(dd));
                });

                return ser.Serialize(new { Success = true, RecycleTypes = recycleTypes });
            }
            catch
            {
                return ser.Serialize(new { Success = false, RecycleTypes = recycleTypes });
            }
        }

        [WebMethod]
        public static string GetLoads(string startDate, string endDate)
        {
            var ser = new JavaScriptSerializer();
            var loads = new List<LoadEntityData>();

            try
            {
                _db.Load.Where(l =>
                     l.Date.Date >= DateTime.Parse(startDate)
                     && l.Date.Date <= DateTime.Parse(endDate)
                     && l.IsActive).ForEach(l =>
                     {
                         loads.Add(LoadEntityData.LoadEntityToData(l));
                     });

                return ser.Serialize(new { Success = true, Loads = loads });
            }
            catch
            {
                return ser.Serialize(new { Success = false, Loads = loads });
            }
        }

        [WebMethod]
        public static string Save(int loadId, string updateBales, string deleteBales, string swapBales)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var updateList = ser.Deserialize<List<BaleEntityData>>(updateBales);
                var deleteList = ser.Deserialize<List<BaleEntityData>>(deleteBales);
                var swapList = ser.Deserialize<List<BaleEntityData>>(swapBales);

                //update
                foreach (var updatedBale in updateList)
                {
                    var foundBale = _db.Bale.FirstOrDefault(b => b.BaleId == updatedBale.BaleId);
                    if (foundBale != null)
                    {
                        if (updatedBale.RecycleTypeId != null)
                        {
                            foundBale.RecycleTypeId = updatedBale.RecycleTypeId.Value;
                        }

                        foundBale.BaleNumber = updatedBale.BaleNumber;
                        foundBale.InitWeight = updatedBale.InitWeight;
                        foundBale.WarehouseWeight = updatedBale.WarehouseWeight;
                        foundBale.FinalWeight = updatedBale.FinalWeight;
                        foundBale.Notes = updatedBale.Notes;

                        foundBale.Save();
                    }
                }

                //delete from this load -> release (set loadId to null)
                foreach (var bale in deleteList)
                {
                    var foundBale = _db.Bale.FirstOrDefault(b => b.BaleId == bale.BaleId);
                    if (foundBale != null)
                    {
                        foundBale.LoadId = null;

                        foundBale.Save();
                    }
                }

                //swap
                foreach (var bale in swapList)
                {
                    var foundBale = _db.Bale.FirstOrDefault(b => b.BaleId == bale.BaleId);
                    if (foundBale != null)
                    {
                        //bale.LoadId will have the new id
                        foundBale.LoadId = bale.LoadId;

                        foundBale.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }
    }

}