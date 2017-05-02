using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;

namespace RenuOil.MasterPages
{
    public partial class Main : System.Web.UI.MasterPage
    {
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
                lnkLoginLogout.Text = "Logout";
                profileItemLink.InnerText = "Logged In: " + sm.AuthenticatedUser.Username;
            }
            else
            {
                lnkLoginLogout.Text = "Login";
            }

            if (sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.Manager)
            {
                lnkUsers.Visible = false;
            }

            if (sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.Loader_Driver)
            {
                administrationItem.Visible = false;
                accountsItem.Visible = false;
                filtrationSchedules.Visible = false;
            }

            if (sm.AuthenticatedUser.UserTypeId == (int)UserTypeEntity.UserTypes.CompanyUser)
            {
                administrationItem.Visible = false;
                accountsItem.Visible = false;
                schedulesItem.Visible = false;
                profileItem.Visible = true;
            }
        }

        protected void lnkLoginLogout_Click(object sender, EventArgs e)
        {
            sm.AuthenticatedUser = null;
            Response.Redirect("Login.aspx");
        }
    }
}
