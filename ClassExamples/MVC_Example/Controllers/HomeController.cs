using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        //home/index 
        public ActionResult Index()
        {
            return View();
        }
        //home/about
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
        for (int i = 0; i<length; i++)
			{

			}
    }
}