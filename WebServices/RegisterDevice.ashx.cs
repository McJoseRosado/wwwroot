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
    public class RegisterDevice : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var values = context.Request.Values();

            string username = values["username"];
            // Note this is Hexadecimal-encoded binary
            string password = values["password"];

            DeviceManager deviceMgr = new DeviceManager(username, password);

            context.Response.ContentType = "text/plain";
            context.Response.Write(deviceMgr.RegisterDevice());
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
