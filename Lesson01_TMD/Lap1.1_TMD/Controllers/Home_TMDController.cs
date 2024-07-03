using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap1._1_TMD.Controllers
{
    public class Home_TMDController : Controller
    {
        // GET: Home_TMD
        public ActionResult Index_TMD()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Chào mừng bạn đến với ASP.NET MVC 5";
            return View();
        }
        //GET: /Home/About
        public ActionResult About_TMD()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Đây là trang About";
            return View();
        }
    }
}