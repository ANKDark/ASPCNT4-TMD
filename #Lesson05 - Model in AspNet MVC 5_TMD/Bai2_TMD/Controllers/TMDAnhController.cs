using Bai2_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2_TMD.Controllers
{
    public class TMDAnhController : Controller
    {
        static Anhh listAnh;
        public TMDAnhController()
        {
            listAnh = new Anhh();
        }
        public ActionResult GetAnhs()
        {
            return View(listAnh.GetAnhs());
        }
        public ActionResult AddAnh()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_TMD(Anh anh)
        {
            listAnh.AddANh(anh);
            return RedirectToAction("GetAnhs");
        }
    }
}