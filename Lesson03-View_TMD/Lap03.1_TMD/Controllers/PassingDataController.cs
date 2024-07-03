using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap03._1_TMD.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult ViewDataTest()
        {
            ViewData["message1"] = "ViewData chỉ tồn tại trong một Request và giá trị trở về null khi chuyển hướng (Redirect)";
            ViewData["message2"] = "ViewData yêu cầu chuyển kiểu dữ liệu và kiểm tra null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiến" };
            ViewData["students"] = students;
            return View();
        }

        public ActionResult ViewBagTest()
        {
            ViewBag.message1 = "ViewBag chỉ tồn tại trong một Request và giá trị trở về null khi chuyển hướng (Redirect)";
            ViewBag.message2 = "ViewBag yêu cầu chuyển kiểu dữ liệu và kiểm tra null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiến" };
            ViewBag.students = students;
            return View();
        }

        public ActionResult TempDataTest()
        {
            TempData["message1"] = "TempData có thể truyền dữ liệu từ request hiện tại tới chuỗi các request con khi sử dụng Redirect";
            TempData["message2"] = "TempData yêu cầu chuyển kiểu dữ liệu và kiểm tra null để tránh lỗi";
            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            ViewBag.message1 = TempData["message1"];
            ViewData["message1"] = TempData["message1"];
            return View();
        }

    }
}