using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TmdK22CNT4Lesson10.Models;

namespace TmdK22CNT4Lesson10.Controllers
{
    public class TmdHomeController : Controller
    {
        public ActionResult TmdIndex()
        {
            // Kiểm tra session
            if (Session["TmdAccount"]  != null)
            {
                var tmdAccount = Session["TmdAccount"] as TmdAccount;
                ViewBag.FullName = tmdAccount.TmdFullName;
            }
            return View();
        }

        public ActionResult TmdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TmdContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}