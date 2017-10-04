using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        //View dashboard summmary 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View(); 
        }
    }
}