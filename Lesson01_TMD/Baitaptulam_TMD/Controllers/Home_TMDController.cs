using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitaptulam_TMD.Controllers
{
    public class Home_TMDController : Controller
    {
        // GET: Home_TMD
        public ActionResult Index()
        {
            ViewBag.Message = "Đại học Nguyễn Trãi";
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}