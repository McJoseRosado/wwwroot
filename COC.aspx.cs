using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RenuOil
{
    public partial class COC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hide alert box
            coc_alert.Visible = false;

            //does it have a message?
            if (!string.IsNullOrEmpty(Request.QueryString["message"]))
            {
                var message = Request.QueryString["message"].ToString();
                coc_alert.Visible = true;
                coc_alert_text.InnerText = message;
            }
        }
    }
}