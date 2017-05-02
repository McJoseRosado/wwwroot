using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using System.Web.UI.HtmlControls;

namespace RenuOil
{
    public partial class Login : System.Web.UI.Page
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

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlAnchor lnkLogin = this.Page.Master.FindControl("lnkLogin") as HtmlAnchor;
            lnkLogin.Attributes["class"] = "selected";
            txtUsername.Focus();
        }

        #endregion

        #region Control Events
        protected void lnkBtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                messages.Controls.Add(new LiteralControl("<strong>Please enter a valid username and password.</strong>"));
                messages.Attributes["class"] = "error";
                messages.Visible = true;
                return;
            }

            UserEntity user = UserEntity.Login(txtUsername.Text, txtPassword.Text);

            if (user == null)
            {
                messages.Controls.Add(new LiteralControl("Could not log in: <strong>Please enter a valid username and password.</strong>"));
                messages.Attributes["class"] = "error";
                messages.Visible = true;
                return;
            }
            else
            {
                sm.AuthenticatedUser = user;
            }

            Response.Redirect("~/Home.aspx");

        }

        #endregion

    }
}
