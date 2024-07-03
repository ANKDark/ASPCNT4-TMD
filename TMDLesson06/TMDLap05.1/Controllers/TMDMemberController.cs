using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDLap05._1.Models;

namespace TMDLap05._1.Controllers
{
    public class TMDMemberController : Controller
    {
        // GET: TMDMember/TMDCreateOne
        public ActionResult TMDCreateOne()
        {
            return View();
        }
        //POST: TMDMember/TMDCreateOne
        [HttpPost]
        public ActionResult TMDCreateOne(TMDMember m) 
        {
            return View("TMDDetails", m);
        }
        // GET: TMDMember/TMDCreateTwo
        public ActionResult TMDCreateTwo()
        {
            return View();
        }
        //POST: TMDMember/TMDCreateTwo
        [HttpPost]
        public ActionResult TMDCreateTwo(TMDMember m)
        {
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số"; 
                return View();
            }
            if (m.TMDUsername == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.TMDFullName == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.TMDAge == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.TMDEmail == null)
            {
                ViewBag.error = "Hãy nhập email";
                return View();
            }
            string TMDregePattern = @"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}";
            if (System.Text.RegularExpressions.Regex.IsMatch(m.TMDEmail, TMDregePattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng"; 
                return View();
            }
            return View("TMDDetails", m);
        }
        // GET: TMDMember/TMDCreateThree
        public ActionResult TMDCreateThree()
        {
            return View();
        }
        //POST: TMDMember/TMDCreateThree
        [HttpPost]
        public ActionResult TMDCreateThree(TMDMember m)
        {
            if (!ModelState.IsValid)
            {
                return View("TMDDetails", m);
            }else
            {
                return View();
            }
        }
        public ActionResult TMDDetails()
        {
            return View();
        }
    }
}