using Lap03._3_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lap03._3_TMD.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTMLHelper
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<Country>() {
                new Country(){ID="0",Name="-- Chọn Quốc Gia --"},
                new Country(){ID="VN",Name="Việt Nam"},
                new Country(){ID="AT",Name="AUSTRALIA"},
                new Country(){ID="UK",Name="Anh"},
                new Country(){ID="FR",Name="Pháp"},
                new Country(){ID="US",Name="Mỹ"},
                new Country(){ID="KP",Name="Hàn Quốc"},
                new Country(){ID="HU",Name="Hồng Kong"},
                new Country(){ID="CN",Name="Trung Quốc"},
                };
            return View();
        }

        public ActionResult Register()
        {
            string fvr = "";

            // Lưu các giá trị vào TempData
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];

            // Xử lý các sở thích được chọn
            if (Request["Reading"] != null && Request["Reading"].Contains("true"))
                fvr += "Reading ,";
            if (Request["Shopping"] != null && Request["Shopping"].Contains("true"))
                fvr += "Shopping ,";
            if (Request["Sport"] != null && Request["Sport"].Contains("true"))
                fvr += "Sport ,";

            TempData["Favourite"] = fvr;

            return View();
        }

    }
}