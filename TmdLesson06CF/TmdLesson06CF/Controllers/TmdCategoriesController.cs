using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TmdLesson06CF.Models;

namespace TmdLesson06CF.Controllers
{
    public class TmdCategoriesController : Controller
    {
        private static TmdBookStore tmdDb;
        public TmdCategoriesController()
        {
            tmdDb = new TmdBookStore();
        }
        // GET: TmdCategories
        public ActionResult TmdIndex()
        {
            /*
             * Khởi tạo DBcontext;
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .Net Famework trên máy
             * Và sau đó tạo csdl
             * */
            var tmdCategory = tmdDb.TmdCategories.ToList();
            return View(tmdCategory);
        }
        public ActionResult TmdCreate()
        {
            var tmdCategory = new TmdCategory();
            return View(tmdCategory);
        }
        [HttpPost]
        public ActionResult TmdCreate(TmdCategory tmdCategory)
        {
            tmdDb.TmdCategories.Add(tmdCategory);
            tmdDb.SaveChanges();
            return RedirectToAction("TmdIndex");
        }
    }
}