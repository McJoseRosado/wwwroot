using System;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    public partial class NewLoad : System.Web.UI.Page
    {
        private LinqMetaData _db = new LinqMetaData();

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/COC.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                new_load_alert.Visible = false;

                driversList.Items.Add(new ListItem("Select driver", "-1"));
                foreach (var employeeEntity in _db.Employee.OrderBy(ee => ee.LastName))
                {
                    driversList.Items.Add(new ListItem(employeeEntity.FullName, employeeEntity.EmployeeId.ToString()));
                }

                loadIdText.InnerText = (_db.Load.ToList().Last().LoadId + 1).ToString();
            }
        }

        protected void btnSaveLoad_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            bool hasError = false;

            try
            {
                if (driversList.SelectedValue == "-1")
                {
                    hasError = true;
                    errorMessage += "Select a driver. ";
                }
                DateTime resultDate;
                if (!DateTime.TryParse(date.Value, out resultDate))
                {
                    hasError = true;
                    errorMessage += "Date is invalid. ";
                }

                if (hasError)
                {
                    new_load_alert.Visible = true;
                    new_load_alert_text.InnerText = errorMessage;
                }
                else
                {
                    LoadEntity load = new LoadEntity();
                    load.Date = resultDate;
                    load.StatusId = 1;
                    load.IsActive = true;
                    load.EmployeeId = int.Parse(driversList.SelectedValue);

                    //get load number
                    var loadsBasedOnDockAndDate = _db.Load.Where(
                        b => b.Date.Date == load.Date.Date &&
                            b.EmployeeId == load.EmployeeId).ToList();

                    //if there is no load created on this date for this employee, set load number = 1
                    if (loadsBasedOnDockAndDate.Count == 0)
                    {
                        load.LoadNumber = 1;
                    }
                    else
                    {
                        var maxNumber = loadsBasedOnDockAndDate.Max(b => b.LoadNumber);
                        //if max is null -> that means all don't have a number, just make it one
                        if (maxNumber == 1)
                        {
                            load.LoadNumber = 1;
                        }
                        else
                        {
                            load.LoadNumber = maxNumber + 1; //find max number, add 1 to get the next available number
                        }
                    }

                    load.Save();

                    Response.Redirect("~/COC.aspx?message=Load created.");
                }
            }
            catch
            {
                new_load_alert.Visible = true;
                new_load_alert_text.InnerText = "An error has occurred.";
            }
        }
    }
}