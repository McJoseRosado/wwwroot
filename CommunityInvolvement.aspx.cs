using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace RenuOil
{
    public partial class CommunityInvolvement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlAnchor lnkCommunityInvolvement = this.Page.Master.FindControl("lnkCommunityInvolvement") as HtmlAnchor;
            lnkCommunityInvolvement.Attributes["class"] = "selected";
        }
    }
}
