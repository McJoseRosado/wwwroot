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

namespace RenuOil.MasterPages
{
    public partial class Coc : System.Web.UI.MasterPage
    {
        private static LinqMetaData _db = new LinqMetaData();

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

        protected void Page_Init(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (sm.AuthenticatedUser != null)
            {
                //lnkLoginLogout.Text = "Logout";
                profileItemLink.InnerText = "Logged In: " + sm.AuthenticatedUser.Username;
            }
            else
            {
                //lnkLoginLogout.Text = "Login";
            }
        }

        protected void lnkLoginLogout_Click(object sender, EventArgs e)
        {
            sm.AuthenticatedUser = null;
            Response.Redirect("Login.aspx");
        }
    }
}
