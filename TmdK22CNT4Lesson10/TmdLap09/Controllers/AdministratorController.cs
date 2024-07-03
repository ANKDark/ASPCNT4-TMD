using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TmdLap09.Controllers
{
    public class AdministratorController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        //đáp ứng hành động login
        [HttpPost]
        public ActionResult Login(string username, string password, bool
        remember)
        {
            //kiểm tra username và password
            if (username.ToLower().Equals("admin") &&
            password.ToLower().Equals("admin"))
            {
                Session["username"] = username;
                //lưu cookie nếu có
                if (remember)
                {
                    HttpCookie user = new HttpCookie("user");
                    user["username"] = username;
                    user["password"] = password;
                    user.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(user);
                }
                //vào trang quản trị
                return RedirectToAction("Index");
            }
            ViewBag.error = "Đăng nhập sai!";
            return View();
        }
        //đáp ứng hành động logout
        public ActionResult Logout()
        {
            //hủy các thông tin
            Session["username"] = null;
            Response.Cookies["user"].Expires = DateTime.Now;
            return RedirectToAction("Login");
        }
    }
}