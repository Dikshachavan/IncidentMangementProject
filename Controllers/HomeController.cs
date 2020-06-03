using NewDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewDemoProject.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities DBEntities = new EmployeeDBEntities();
        public ActionResult Index()
        {
            //List<INCIDENT_BUSINESS_FUNCTION_LOOKUP> Business_Function = DBEntities.INCIDENT_BUSINESS_FUNCTION_LOOKUP.ToList();
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