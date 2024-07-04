using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TmdLesson11Db_2210900014.Controllers
{
    public class TmdHomeController : Controller
    {
        public ActionResult TmdIndex()
        {
            return View();
        }

        public ActionResult TmdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TmdContact()
        {
            ViewBag.Msv = "2210900014";
            ViewBag.fullname = "Trần Minh Đức";
            return View();
        }
    }
}