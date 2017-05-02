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
using Telerik.Web.UI.Calendar;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using System.Collections;

namespace RenuOil
{
    public partial class NewOrExistingOilFiltration : System.Web.UI.Page
    {
        private SessionManager _sm
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}