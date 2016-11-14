using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test0927_02.Controllers
{
    public class HomeController : Controller
    {
        public string Index2()
        {
            return "Hello mr booöåänd";
        }
        //GET: Home
        public ActionResult Index()
        {
            //per default hamnar vi här
                //pga MS mvc Conventions

            //vad är våran VIEW
            //vad heter våran VIEW
            //per default ska den heta index
            //dvs samma som metod heter
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}