using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class NewDock : System.Web.UI.Page
    {
        private LinqMetaData _db = new LinqMetaData();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                new_dock_alert.Visible = false;

                //add a default one first
                propertiesList.Items.Add(new ListItem("Select property", "-1"));

                //get all accounts for the dropdown list
                foreach (var accountEntity in _db.Account.OrderBy(a => a.Name))
                {
                    propertiesList.Items.Add(new ListItem(accountEntity.Name, accountEntity.AccountId.ToString()));
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC.aspx");
        }

        protected void btnSaveDock_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            bool hasError = false;

            try
            {
                //selected a property?
                if (propertiesList.SelectedValue == "-1")
                {
                    hasError = true;
                    errorMessage += "Select a property. ";
                }

                if (string.IsNullOrEmpty(dockName.Value))
                {
                    hasError = true;
                    errorMessage += "Enter a dock name. ";
                }

                if (hasError)
                {
                    new_dock_alert.Visible = true;
                    new_dock_alert_text.InnerText = errorMessage;
                }
                else
                {
                    DockEntity dock = new DockEntity();
                    dock.DockName = dockName.Value;
                    dock.AccountId = int.Parse(propertiesList.SelectedValue);
                    dock.IsActive = true;
                    dock.Save();

                    Response.Redirect("~/COC.aspx?message=Dock created.");
                }
            }
            catch
            {
                new_dock_alert.Visible = true;
                new_dock_alert_text.InnerText = "An error has occurred.";
            }
        }
    }
}