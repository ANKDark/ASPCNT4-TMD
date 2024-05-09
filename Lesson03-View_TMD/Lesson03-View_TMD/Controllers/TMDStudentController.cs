using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson03_View_TMD.Controllers
{
    public class TMDStudentController : Controller
    {
        // GET: TMDStudent
        public ActionResult Index()
        {
            ViewData["msg"] = "View Data - Trần Minh Đức";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }

        public ActionResult StudentList() 
        {
            // Sử dụng ViewBag
            //Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Trần Minh Đức";

            //Giá trị là một tập hợp
            string[] names = { "Trần Đức", "2210900014", "K22CNT4"};
            ViewBag.list = names;

            // Giá trị là một đối tượng
            var obj = new
            {
                ID = 1000,
                Name = "Trần Đức",
                Age = 19
            };
            ViewBag.student = obj;
            return View();
        }

        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}