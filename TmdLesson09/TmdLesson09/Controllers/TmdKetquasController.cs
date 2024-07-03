using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLesson09.Models;

namespace TmdLesson09.Controllers
{
    public class TmdKetquasController : Controller
    {
        private tmd_qlsinhvienEntities db = new tmd_qlsinhvienEntities();

        // GET: TmdKetquas
        public ActionResult TmdIndex()
        {
            var tmdKetqua = db.TmdKetqua.Include(t => t.TmdMonHoc).Include(t => t.TmdSinhVien);
            return View(tmdKetqua.ToList());
        }

        // GET: TmdKetquas/Details/5
        public ActionResult TmdDetails(string tmdMaMH, string tmdMaSV)
        {
            if (tmdMaMH == null || tmdMaSV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKetqua tmdKetqua = db.TmdKetqua.Find(tmdMaMH, tmdMaSV);
            if (tmdKetqua == null)
            {
                return HttpNotFound();
            }
            return View(tmdKetqua);
        }

        // GET: TmdKetquas/Create
        public ActionResult TmdCreate()
        {
            ViewBag.TmdMaMH = new SelectList(db.TmdMonHoc, "TmdMaMH", "TmdTenMH");
            ViewBag.TmdMaSV = new SelectList(db.TmdSinhVien, "TmdMaSV", "TmdHoSV");
            return View();
        }

        // POST: TmdKetquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "TmdMaMH,TmdMaSV,TmdDiem")] TmdKetqua tmdKetqua)
        {
            if (ModelState.IsValid)
            {
                db.TmdKetqua.Add(tmdKetqua);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            ViewBag.TmdMaMH = new SelectList(db.TmdMonHoc, "TmdMaMH", "TmdTenMH", tmdKetqua.TmdMaMH);
            ViewBag.TmdMaSV = new SelectList(db.TmdSinhVien, "TmdMaSV", "TmdHoSV", tmdKetqua.TmdMaSV);
            return View(tmdKetqua);
        }

        // GET: TmdKetquas/Edit/5
        public ActionResult TmdEdit(string tmdMaMH, string tmdMaSV)
        {
            if (tmdMaMH == null || tmdMaSV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKetqua tmdKetqua = db.TmdKetqua.Find(tmdMaMH, tmdMaSV);
            if (tmdKetqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.TmdMaMH = new SelectList(db.TmdMonHoc, "TmdMaMH", "TmdTenMH", tmdKetqua.TmdMaMH);
            ViewBag.TmdMaSV = new SelectList(db.TmdSinhVien, "TmdMaSV", "TmdHoSV", tmdKetqua.TmdMaSV);
            return View(tmdKetqua);
        }

        // POST: TmdKetquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        // POST: TmdKetquas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "TmdMaMH,TmdMaSV,TmdDiem")] TmdKetqua tmdKetqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdKetqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            ViewBag.TmdMaMH = new SelectList(db.TmdMonHoc, "TmdMaMH", "TmdTenMH", tmdKetqua.TmdMaMH);
            ViewBag.TmdMaSV = new SelectList(db.TmdSinhVien, "TmdMaSV", "TmdHoSV", tmdKetqua.TmdMaSV);
            return View(tmdKetqua);
        }

        // GET: TmdKetquas/Delete/5
        public ActionResult TmdDelete(string tmdMaMH, string tmdMaSV)
        {
            if (tmdMaMH == null || tmdMaSV == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKetqua tmdKetqua = db.TmdKetqua.Find(tmdMaMH, tmdMaSV);
            if (tmdKetqua == null)
            {
                return HttpNotFound();
            }
            return View(tmdKetqua);
        }

        // POST: TmdKetquas/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(string tmdMaMH, string tmdMaSV)
        {
            TmdKetqua tmdKetqua = db.TmdKetqua.Find(tmdMaMH, tmdMaSV);
            db.TmdKetqua.Remove(tmdKetqua);
            db.SaveChanges();
            return RedirectToAction("TmdIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
