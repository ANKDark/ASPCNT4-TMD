using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMD_Lesson02.Controllers
{
    public class TMDStudentController : Controller
    {
        /// <summary>
        /// Author: Trần Minh Đức
        /// Class: K22CNT4
        /// </summary>
        /// <returns></returns>
        // GET: TMDStudent
        public ActionResult Index()
        {
            // Truyền dữ liệu từ controller lên View
            ViewBag.fullname = "Trần Minh Đức";
            ViewData["Birthday"] = "24/07/2004";
            TempData["Phone"] = "0855312279";

            return View();
        }

        public ActionResult Details() 
        {
            string tmdStr = "";
            tmdStr += "<h3>Họ và tên: Trần Minh Đức <h3/>";
            tmdStr += "<p>Mã sv: 2210900014 <p/>";
            tmdStr += "<p>Địa chỉ gmail: dinhhoangducdbp2004@gmail.com<p/>";
            ViewBag.Details = tmdStr;
            return View("chitiet");
        }

        public ActionResult NgonNguRazor ()
        {
            string[] names = { "Trần Minh Đức", "Hoàng Kim Oanh", "Trần ...", "Đức đẹp trai" };
            ViewBag.names = names;
            return View();
        }

        //HTMLHelper

        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //Lấy dữ liệu trên form
            string fullname = form["Fullname"];
            string masv = form["maSV"];
            string taikhoan = form["Taikhoan"];
            string matkhau = form["matkhau"];

            string tmdStr = "<h3>" + fullname + "<h3/>";
            tmdStr += "<p>" + masv;
            tmdStr += "<p>" + taikhoan;
            tmdStr += "<p>" + matkhau;

            ViewBag.info = tmdStr;
            return View("ketqua");
        }
    }
}