using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Reliant.RenuOil.Business;
using Reliant.RenuOil.Business.Mobile;
using ReliantUtilityLibrary;

namespace RenuOil.WebServices
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class GetDeviceInfo : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            DeviceManager deviceMgr;
            var values = context.Request.Values();
            string username = values["username"];
            // Note this is Hexadecimal-encoded binary
            string password = values["password"];
            if (values["deviceToken"] != "undefined")
            {
                Guid deviceToken = new Guid(values["deviceToken"]);
                deviceMgr = new DeviceManager(deviceToken);
            }
            else
                deviceMgr = new DeviceManager(username, password);

            context.Response.ContentType = "text/plain";
            context.Response.Write(deviceMgr.GetDeviceInfo());
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
