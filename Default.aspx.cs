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
    public partial class Pages_Default : System.Web.UI.Page
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //UserEntity user = UserEntity.Login(txtUserName.Text, txtPassword.Text);

            //if (user == null)
            //{
            //    //messages.Controls.Add(new LiteralControl("Could not log in: <strong>Please enter a valid username and password.</strong>"));
            //    return;
            //}
            //else
            //{
            //    sm.AuthenticatedUser = user;
            //}

            //Response.Redirect("~/Home.aspx");

        }

    }

}