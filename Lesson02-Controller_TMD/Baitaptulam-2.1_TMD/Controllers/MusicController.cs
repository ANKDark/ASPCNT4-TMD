using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitaptulam_2._1_TMD.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            /*byte[] fileBytes =
            System.IO.File.ReadAllBytes(Server.MapPath("~/Content/ĐIỀU EM KHÔNG MUỐN NGHE - QNT, DICK (prod. by PhongKhin).mp3"));
            string fileName = "ĐIỀU EM KHÔNG MUỐN NGHE - QNT, DICK (prod. by PhongKhin).mp3";
            return File(fileBytes, "video/mp3", fileName);*/
            return View();
        }

    }
}