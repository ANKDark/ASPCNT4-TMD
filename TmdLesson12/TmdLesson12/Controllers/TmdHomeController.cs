using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TmdLesson12.Controllers
{
    public class TmdHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trần Minh Đức - 2210900014";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trần Minh Đức - 2210900014";

            return View();
        }
    }
}