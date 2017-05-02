using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;

namespace RenuOil
{
    public partial class NotAuthorized : System.Web.UI.Page
    {
        #region Members
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

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlAnchor lnkHome = this.Page.Master.FindControl("lnkHome") as HtmlAnchor;
            lnkHome.Attributes["class"] = "selected";
        }
    }

}