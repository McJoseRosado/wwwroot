using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ReliantUtilityLibrary;

namespace RenuOil
{
    public partial class Users : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();

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
            if (sm.AuthenticatedUser.UserTypeId != (int)UserTypeEntity.UserTypes.Administrator)
            {
                Response.Redirect("NotAuthorized.aspx");
            }
            // users
            populate();
        }

        private void populate()
        {
            var users = from u in _db.User
                        where u.UserTypeId != 5 && u.IsActive
                        orderby u.LastName, u.FirstName
                        select u;

            rptUsers.DataSource = users;
            rptUsers.DataBind();

            var users2 = from u in _db.User
                         where u.UserTypeId == 5 && u.IsActive // 5 is the user type id for facility users
                         orderby u.LastName, u.FirstName
                         select u;

            rptFacilityUsers.DataSource = users2;
            rptFacilityUsers.DataBind();
        }

        #endregion

        #region Control Events
        protected void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditUser.aspx?userId=0");
        }

        #endregion

        #region Repeater Events
        protected void rptUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                UserEntity user = e.Item.DataItem as UserEntity;

                LinkButton lnkBtnEditUser = e.Item.FindControl("lnkBtnEditUser") as LinkButton;
                Label lblUsername = e.Item.FindControl("lblUsername") as Label;

                lblUsername.Text = user.Username;
                lnkBtnEditUser.Text = user.LastName + ", " + user.FirstName;
            }
        }

        protected void rptUsers_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditUser.aspx?userId=" + e.CommandArgument.ToString());
                    break;

                case "Delete":
                    var user = _db.User.FirstOrDefault(u => u.UserId == int.Parse(e.CommandArgument.ToString()));
                    user.IsActive = false;
                    user.Save();
                    populate();

                    break;

                default:
                    break;

            }
        }

        protected void rptFacilityUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.IsDataItem())
            {
                UserEntity user = e.Item.DataItem as UserEntity;

                LinkButton lnkBtnEditFacilityUser = e.Item.FindControl("lnkBtnEditFacilityUser") as LinkButton;
                Label lblUsername = e.Item.FindControl("lblUsername") as Label;

                lblUsername.Text = user.Username;
                lnkBtnEditFacilityUser.Text = user.LastName + ", " + user.FirstName;
            }
        }

        protected void rptFacilityUsers_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    Response.Redirect("~/EditUser.aspx?userId=" + e.CommandArgument.ToString());
                    break;

                case "Delete":
                    var user = _db.User.FirstOrDefault(u => u.UserId == int.Parse(e.CommandArgument.ToString()));
                    user.IsActive = false;
                    user.Save();
                    populate();

                    break;

                default:
                    break;

            }
        }

        #endregion
    }
}
