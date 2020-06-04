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
            Employee em = new Employee();
            return View(em);
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