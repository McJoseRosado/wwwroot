using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using Reliant.RenuOil.Business.Mobile;
using System.IO;
using ReliantUtilityLibrary;
using System.Configuration;

namespace RenuOil.WebServices
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UploadWorkOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var values = context.Request.Values();

            Guid deviceToken = new Guid(values["deviceToken"]);
            int employeeId;
            int.TryParse(values["employeeId"], out employeeId);
            string xml = values["workOrderData"];

            // Decode the encoded string.
            xml = HttpUtility.UrlDecode(xml);

            string username = ConfigurationManager.AppSettings["ImpersonatorUsername"];
            string password = ConfigurationManager.AppSettings["ImpersonatorPassword"];
            string domain = ConfigurationManager.AppSettings["ImpersonatorDomain"];

            //using (new Impersonator(username, domain, password))
            //{
            //    File.WriteAllText(Path.Combine(SettingsUtility.GetSetting("MobileXMLPath"),
            //        DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml"), xml);
            //}

            MobileWorkOrderManager mobileManager = new MobileWorkOrderManager(deviceToken, employeeId);
            context.Response.ContentType = "text/xml";
            context.Response.Write(mobileManager.UploadWorkOrder(xml));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
