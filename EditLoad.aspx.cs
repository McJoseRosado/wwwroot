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
    public partial class EditLoad : System.Web.UI.Page
    {
        protected List<AccountEntity> Properties;
        protected LoadEntity Load;

        private static LinqMetaData _db = new LinqMetaData();

        protected void BackToCoc(object sender, EventArgs e)
        {
            Response.Redirect("~/Coc.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ExistingLoads.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int loadId;
                PropertiesList.Items.Add(new ListItem("Select property", "-1"));
                foreach (var accountEntity in _db.Account.OrderBy(a => a.Name))
                {
                    PropertiesList.Items.Add(new ListItem(accountEntity.Name, accountEntity.AccountId.ToString()));
                }

                loadId = int.Parse(Request["loadId"]);

                var load = _db.Load.FirstOrDefault(l => l.LoadId == loadId);

                if (load != null)
                {
                    Load = load;
                }
            }
        }

        [WebMethod]
        public static string GetBalesInProperty(int propertyId, int loadId)
        {
            var ser = new JavaScriptSerializer();
            var availableBales = new List<BaleEntityData>();
            var selectedBales = new List<BaleEntityData>();

            try
            {
                _db.Bale.Where(d => d.AccountId == propertyId && d.LoadId == null && d.IsActive).ForEach(dd =>
                {
                    availableBales.Add(BaleEntityData.BaleEntityToData(dd));
                });

                _db.Bale.Where(d => d.AccountId == propertyId && d.LoadId == loadId && d.IsActive).ForEach(dd =>
                {
                    selectedBales.Add(BaleEntityData.BaleEntityToData(dd));
                });

                return ser.Serialize(new { Success = true, selectedBales = selectedBales, availableBales = availableBales });
            }
            catch
            {
                return ser.Serialize(new { Success = false, selectedBales = selectedBales, availableBales = availableBales });
            }
        }

        [WebMethod]
        public static string UpdateBale(int baleId, bool isChecked, int loadId)
        {
            var ser = new JavaScriptSerializer();

            try
            {
                var bale = _db.Bale.FirstOrDefault(b => b.BaleId == baleId);
                if (bale != null)
                {
                    if (isChecked)
                    {
                        bale.LoadId = loadId;
                        bale.Save();
                    }
                    else
                    {
                        bale.LoadId = null;
                        bale.Save();
                    }
                }

                return ser.Serialize(new { Success = true, accountId = bale.AccountId });
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }
        }
    }
}