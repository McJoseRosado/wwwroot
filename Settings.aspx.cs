using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using ReliantUtilityLibrary;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class Settings : System.Web.UI.Page
    {
        #region Members
        private LinqMetaData _db = new LinqMetaData();
        private SettingEntity baleWeightSetting = null;
        private SettingEntity numberOfBagsInBale = null;
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
            var settings = from s in _db.Setting
                           select s;

            baleWeightSetting = settings.Where(x => x.Name == "BaleWeight").First();
            numberOfBagsInBale = settings.Where(x => x.Name == "NumberOfBagsInBale").First();

            if (!Page.IsPostBack)
            {
                populate();
                errormessages.Controls.Clear();
                errormessages.Visible = false;
            }
        }

        private void populate()
        {
            txtBaleWeight.Text = baleWeightSetting.DecimalValue.ToString();
            txtNumberOfBagsInBale.Text = numberOfBagsInBale.IntValue.ToString();
        }

        protected void btnSaveSettingss_Click(object sender, EventArgs e)
        {
            if (txtBaleWeight.Text.Trim().Length == 0 || txtNumberOfBagsInBale.Text.Trim().Length == 0)
            {
                errormessages.Controls.Add(HtmlHelper.Div("You must enter values."));
                errormessages.Visible = true;
                return;
            }

            baleWeightSetting.DecimalValue = Convert.ToDecimal(txtBaleWeight.Text.Trim());
            baleWeightSetting.IsDirty = true;
            baleWeightSetting.Save();
            numberOfBagsInBale.IntValue = Convert.ToInt32(txtNumberOfBagsInBale.Text.Trim());
            numberOfBagsInBale.IsDirty = true;
            numberOfBagsInBale.Save();
            Response.Redirect("Home.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

    }
}
