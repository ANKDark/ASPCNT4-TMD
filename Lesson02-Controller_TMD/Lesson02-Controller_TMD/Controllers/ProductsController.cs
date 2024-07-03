using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_Controller_TMD.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.name="Trần Minh Đức - 2210900014";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        public string GetName()
        {
            return "Trần Minh Đức - 2210900014";
        }

        public JsonResult ListName()
        {
            string[] names = { "Đức", "Đức", "Đức", "Đức" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}