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
    public class TmdSinhViensController : Controller
    {
        private tmd_qlsinhvienEntities db = new tmd_qlsinhvienEntities();

        // GET: TmdSinhViens
        public ActionResult Index()
        {
            var tmdSinhVien = db.TmdSinhVien.Include(t => t.TmdKhoa);
            return View(tmdSinhVien.ToList());
        }

        // GET: TmdSinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdSinhVien tmdSinhVien = db.TmdSinhVien.Find(id);
            if (tmdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(tmdSinhVien);
        }

        // GET: TmdSinhViens/Create
        public ActionResult Create()
        {
            ViewBag.TmdMaKH = new SelectList(db.TmdKhoa, "TmdMaKH", "TmdTenKH");
            return View();
        }

        // POST: TmdSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdMaSV,TmdHoSV,TmdTenSV,TmdPhai,TmdNgaySinh,TmdNoiSinh,TmdMaKH,TmdHocBong,TmdDiemTrungBinh")] TmdSinhVien tmdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.TmdSinhVien.Add(tmdSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TmdMaKH = new SelectList(db.TmdKhoa, "TmdMaKH", "TmdTenKH", tmdSinhVien.TmdMaKH);
            return View(tmdSinhVien);
        }

        // GET: TmdSinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdSinhVien tmdSinhVien = db.TmdSinhVien.Find(id);
            if (tmdSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.TmdMaKH = new SelectList(db.TmdKhoa, "TmdMaKH", "TmdTenKH", tmdSinhVien.TmdMaKH);
            return View(tmdSinhVien);
        }

        // POST: TmdSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdMaSV,TmdHoSV,TmdTenSV,TmdPhai,TmdNgaySinh,TmdNoiSinh,TmdMaKH,TmdHocBong,TmdDiemTrungBinh")] TmdSinhVien tmdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TmdMaKH = new SelectList(db.TmdKhoa, "TmdMaKH", "TmdTenKH", tmdSinhVien.TmdMaKH);
            return View(tmdSinhVien);
        }

        // GET: TmdSinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdSinhVien tmdSinhVien = db.TmdSinhVien.Find(id);
            if (tmdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(tmdSinhVien);
        }

        // POST: TmdSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TmdSinhVien tmdSinhVien = db.TmdSinhVien.Find(id);
            db.TmdSinhVien.Remove(tmdSinhVien);
            db.SaveChanges();
            return RedirectToAction("Index");
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
