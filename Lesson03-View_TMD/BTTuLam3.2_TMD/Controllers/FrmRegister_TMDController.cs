using BTTuLam3._2_TMD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTuLam3._2_TMD.Controllers
{
    public class FrmRegister_TMDController : Controller
    {
        // GET: FrmRegister_TMD
        public ActionResult FormRegister_TMD()
        {
            var listLoaihinhdoanhnghiep = new List<Loaihinhdoanhnghiep>() {
                new Loaihinhdoanhnghiep(){ID="1", Name="Công ty TNHH"},
                new Loaihinhdoanhnghiep(){ID="2", Name="Công ty Cổ phần"},
                new Loaihinhdoanhnghiep(){ID="3", Name="Doanh nghiệp tư nhân"},
            };

            ViewBag.ListLoaihinhdoanhnghiep = new SelectList(listLoaihinhdoanhnghiep, "ID", "Name");

            return View();
        }

        public ActionResult Capnhat()
        {
            TempData["txtNameTMD"] = Request["txtNameTMD"];
            TempData["Loaihinhdoanhnghiep"] = Request["Loaihinhdoanhnghiep"];
            TempData["txtAddress"] = Request["txtAddress"];
            TempData["txtnguoilienhe"] = Request["txtnguoilienhe"];
            TempData["numberPhone"] = Request["numberPhone"];
            TempData["txtUName"] = Request["txtUName"];
            TempData["txtPass"] = Request["txtPass"];
            TempData["YesNo"] = Request["YesNo"];
            return View();
        }

    }
}