using Lanco_Project.Models;
using Lanco_Project.Models.Permision;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lanco_Project.Controllers
{
    [SessionValidate]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult CloseSession()
        {
            Session["User"] = null;

            return RedirectToAction("Login", "Access");
        }
    }
}