using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RenuOil
{
    public partial class Receiver : System.Web.UI.Page
    {
        private DataTable RecieverData;   
        protected void Page_Load(object sender, EventArgs e)
        {
            RecieverData = new DataTable("RecieverData");

            RecieverData.Columns.Add("Property", typeof(string));
            RecieverData.Columns.Add("Dock", typeof(string));
            RecieverData.Columns.Add("Bale", typeof(int));
            RecieverData.Columns.Add("Comm", typeof(string));
            RecieverData.Columns.Add("InitWt", typeof(float));
            RecieverData.Columns.Add("WharehouseWt", typeof(float));
            RecieverData.Columns.Add("FinalWt", typeof(float));
            RecieverData.Columns.Add("Notes", typeof(string));


            RecieverData.Rows.Add("Ballys", "Main", 18, "OCC", 618, 600, 600, "Bale smells unusually bad...");
            RecieverData.Rows.Add("Ballys", "Main", 19, "HDPE", 594, 585, 477.25, "");
            RecieverData.Rows.Add("Ballys", "Main", 20, "UBC", 819, 823, 679.55, "Dripping questionable fluids.");
            RecieverData.Rows.Add("Ballys", "Main", 21, "PET", 428, 419, 419, "");
            //RecieverData.Rows.Add("Ballys", "K5", 23, "OCC", 698, 676, 676, "");
            RecieverData.Rows.Add("Ballys", "Conference", 24, "HDPE", 585, 579, 579, "");

            RecieverData.Rows.Add("Flamingo", "Main", 11, "OCC", 621, 619, 619, "");
            //RecieverData.Rows.Add("Flamingo", "Main", 12, "OCC", 615, 612, 612, "");
            RecieverData.Rows.Add("Flamingo", "Main", 11, "HDPE", 580, 579, 579, "");

            RecieverData.Rows.Add("Paris", "Spa", 25, "PET", 419, 417, 417, "");
            //RecieverData.Rows.Add("Paris", "Main", 26, "UDP", 600, 588, 588, "");

            GVReceiver.DataSource = RecieverData;
            GVReceiver.DataBind();
        }
    }
}