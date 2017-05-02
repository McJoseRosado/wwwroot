using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reliant.RenuOil.DAL.Linq;
using ReliantUtilityLibrary;
using Reliant.RenuOil.Business.DocumentGeneration;

namespace RenuOil
{
    public partial class Reports : System.Web.UI.Page
    {
        private LinqMetaData _db = new LinqMetaData();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populateCombos();
            }
        }

        private void populateCombos()
        {
            ddlAccount.Bind(_db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList(), "Name", "AccountId");
            cblAccounts.DataSource = _db.Account.Where(a => a.IsActive).OrderBy(a => a.Name).ToList();
            cblAccounts.DataBind();

            var firstItem = _db.RecycleVendorService.OrderBy(r => r.ServiceDate).FirstOrDefault();
            if (firstItem == null)
            {
            }
            else
            {
                var year = firstItem.ServiceDate.Year;
                while (year <= DateTime.Today.Year)
                {
                    ddlYears.Items.Add(new ListItem(year.ToString(), year.ToString()));
                    year++;
                }
            }
        }

        protected void btnGenerateReport_Click(object sender, EventArgs e)
        {
            RecyclingDivertedTonnageReport dg = new RecyclingDivertedTonnageReport(Convert.ToInt32(ddlAccount.SelectedValue), Convert.ToInt32(ddlYears.SelectedValue));
            publishReportForWeb(dg.Generate());
        }

        protected void btnGenerateFsrReport_Click(object sender, EventArgs e)
        {
            FsrMessages.Controls.Clear();
            var isError = false;
            if (!rdpFSREndDate.SelectedDate.HasValue)
            {
                FsrMessages.AddErrorDiv("Start Date Required");
                isError = true;
            }
            if (!rdpFSREndDate.SelectedDate.HasValue)
            {
                FsrMessages.AddErrorDiv("End Date Required");
                isError = true;
            }


            var ids = cblAccounts.Items.Cast<ListItem>().Where(li => li.Selected).Select(li => int.Parse(li.Value)).ToList();

            if (ids.Count == 0)
            {
                FsrMessages.AddErrorDiv("Must select at least one account.");
                isError = true;
            }

            if (isError)
            {
                return;
            }

            var fps = new FiltrationProgramSavingsReport(ids, rdpFSRStartDate.SelectedDate.Value, rdpFSREndDate.SelectedDate.Value, chkShowDetails.Checked);

            Response.ContentType = "text/csv";
            Response.AddHeader("content-disposition", "attachment;filename=Report-" + string.Format("{0}.csv", DateTime.Now.ToString("MMddyyyy")));

            var resp = fps.CsvString;
            Response.Write(resp);
            Response.End();
        }

        public void publishReportForWeb(Siberix.Report.Report Report)
        {
            try
            {
                System.Web.HttpContext context = System.Web.HttpContext.Current;
                System.Web.HttpResponse response = context.Response;
                response.Clear();

                //PDF
                response.ContentType = "application/pdf";
                response.AddHeader("content-disposition", "attachment; filename=report-" + string.Format("{0}.pdf", DateTime.Now.ToString("MMddyy")));

                Report.Publish(response.OutputStream, Siberix.Report.FileFormat.PDF);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
                response.Close();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
        protected void btnAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in cblAccounts.Items)
        {
             li.Selected = true;
        }    
            //cblAccounts
            //Response.Redirect("~/Home.aspx");
        }
    }
}