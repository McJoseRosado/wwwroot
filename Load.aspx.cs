using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RenuOil
{
    public partial class Load : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NewLoadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewLoad.aspx");
        }

        protected void ExistingButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExistingLoad.aspx");
        }
    }
}