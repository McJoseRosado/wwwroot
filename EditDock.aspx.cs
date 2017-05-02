using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class EditDock : System.Web.UI.Page
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
        protected List<DockEntity> Docks = new List<DockEntity>();
        protected List<AccountEntity> Properties = new List<AccountEntity>();

        private static LinqMetaData _db = new LinqMetaData();

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //get all accounts for the dropdown list
            Properties = _db.Account.OrderBy(a => a.Name).ToList();
            Docks = _db.Dock.ToList();
        }

        [WebMethod]
        public static string Save(int accountId, int dockId, string name)
        {
            var ser = new JavaScriptSerializer(); ;
            try
            {
                var dock = _db.Dock.ToList().FirstOrDefault(d => d.DockId == dockId);
                if (dock != null)
                {
                    dock.AccountId = accountId;
                    dock.DockName = name;
                    dock.Save();
                }
            }
            catch
            {
                return ser.Serialize(new { Success = false });
            }

            return ser.Serialize(new { Success = true });
        }

        [WebMethod]
        public static string Delete(int dockId)
        {
            var ser = new JavaScriptSerializer();
            try
            {
                var dock = _db.Dock.ToList().FirstOrDefault(d => d.DockId == dockId);
                if (dock != null)
                {
                    dock.IsActive = false;
                    dock.Save();
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