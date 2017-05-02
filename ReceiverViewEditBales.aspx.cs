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

namespace RenuOil
{
    public partial class ReceiverViewEditBales : System.Web.UI.Page
    {
        protected LoadEntity Load;
        protected List<BaleEntity> Bales;
        protected List<AccountEntity> Properties = new List<AccountEntity>();
        protected List<RecycleTypeEntity> RecycleTypesList = new List<RecycleTypeEntity>();

        private static LinqMetaData _db = new LinqMetaData();

        protected void BackToCoc(object sender, EventArgs e)
        {
            Response.Redirect("~/Coc.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReceiverView.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var loadId = Request["loadId"];

                ///test
                if (loadId == null)
                {
                    loadId = "67";
                }

                if (loadId != null && _db.Load.FirstOrDefault(l => l.LoadId == int.Parse(loadId)) != null)
                {
                    Load = _db.Load.FirstOrDefault(l => l.LoadId == int.Parse(loadId));
                    Bales = _db.Bale.Where(b => b.LoadId == Load.LoadId).ToList();

                }

                Properties = _db.Account.OrderBy(a => a.Name).ToList();
                RecycleTypesList = _db.RecycleType.OrderBy(a => a.Name).ToList();
            }
        }

        [WebMethod]
        public static string Save(int loadId, string bales)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var list = ser.Deserialize<List<BaleEntityData>>(bales);

                foreach (var updatedBale in list)
                {
                    var foundBale = _db.Bale.FirstOrDefault(b => b.BaleId == updatedBale.BaleId);
                    if (foundBale != null)
                    {
                        if (updatedBale.RecycleTypeId != null)
                        {
                            foundBale.RecycleTypeId = updatedBale.RecycleTypeId.Value;
                        }

                        foundBale.InitWeight = updatedBale.InitWeight;
                        foundBale.WarehouseWeight = updatedBale.WarehouseWeight;
                        foundBale.FinalWeight = updatedBale.FinalWeight;
                        foundBale.Notes = updatedBale.Notes;

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