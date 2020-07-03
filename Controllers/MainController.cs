using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Links.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()

        {

            return View();

        }



        public ActionResult Contactus()

        {

            return View();

        }

       
    }
}
