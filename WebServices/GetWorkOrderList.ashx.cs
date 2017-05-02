using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using Reliant.RenuOil.Business.Mobile;
using System.IO;
using ReliantUtilityLibrary;

namespace RenuOil.WebServices
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    /// 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class GetWorkOrderList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var values = context.Request.Values();

            Guid deviceToken = new Guid(values["deviceToken"]);
            int employeeId;
            int.TryParse(values["employeeId"], out employeeId);

            MobileWorkOrderManager mobileManager = new MobileWorkOrderManager(deviceToken, employeeId);

            context.Response.ContentType = "text/xml";
            context.Response.Write(mobileManager.GetAvailableWorkOrders());
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
