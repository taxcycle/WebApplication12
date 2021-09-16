using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Config;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var xeroConfig = new XeroConfiguration();
            xeroConfig.ClientId = "your client id";
            xeroConfig.ClientSecret = "your client secret";
            xeroConfig.CallbackUri = new Uri("https://b53a-206-174-203-243.ngrok.io/try-now?ssu=xero");
            xeroConfig.Scope = "openid profile email accounting.settings.read";
            var xeroClient = new XeroClient(xeroConfig);
            var loginUri = xeroClient.BuildLoginUri();
            Debug.WriteLine(loginUri);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}