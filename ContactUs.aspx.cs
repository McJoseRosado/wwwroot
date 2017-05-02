using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace RenuOil
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlAnchor lnkContactUs = this.Page.Master.FindControl("lnkContactUs") as HtmlAnchor;
            lnkContactUs.Attributes["class"] = "selected";
        }
    }
}
