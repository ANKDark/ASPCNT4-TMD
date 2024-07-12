using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLesson12.Models;

namespace TmdLesson12.Controllers
{
    public class Tmd_SachController : Controller
    {
        private TranMinhDuc_2210900014Entities1 db = new TranMinhDuc_2210900014Entities1();

        // GET: Tmd_Sach
        public ActionResult TmdIndex()
        {
            var tmd_Sach = db.Tmd_Sach.Include(t => t.Tmd_TacGia);
            return View(tmd_Sach.ToList());
        }

        // GET: Tmd_Sach/Details/5
        public ActionResult TmdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_Sach tmd_Sach = db.Tmd_Sach.Find(id);
            if (tmd_Sach == null)
            {
                return HttpNotFound();
            }
            return View(tmd_Sach);
        }

        // GET: Tmd_Sach/Create
        public ActionResult TmdCreate()
        {
            ViewBag.Tmd_MaTG = new SelectList(db.Tmd_TacGia, "Tmd_MaTG", "Tmd_TenTacGia");
            return View();
        }

        // POST: Tmd_Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "Tmd_MaSach,Tmd_TenSach,Tmd_SoTrang,Tmd_NamXB,Tmd_MaTG,Tmd_TrangThai")] Tmd_Sach tmd_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Tmd_Sach.Add(tmd_Sach);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            ViewBag.Tmd_MaTG = new SelectList(db.Tmd_TacGia, "Tmd_MaTG", "Tmd_TenTacGia", tmd_Sach.Tmd_MaTG);
            return View(tmd_Sach);
        }

        // GET: Tmd_Sach/Edit/5
        public ActionResult TmdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_Sach tmd_Sach = db.Tmd_Sach.Find(id);
            if (tmd_Sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.Tmd_MaTG = new SelectList(db.Tmd_TacGia, "Tmd_MaTG", "Tmd_TenTacGia", tmd_Sach.Tmd_MaTG);
            return View(tmd_Sach);
        }

        // POST: Tmd_Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "Tmd_MaSach,Tmd_TenSach,Tmd_SoTrang,Tmd_NamXB,Tmd_MaTG,Tmd_TrangThai")] Tmd_Sach tmd_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmd_Sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            ViewBag.Tmd_MaTG = new SelectList(db.Tmd_TacGia, "Tmd_MaTG", "Tmd_TenTacGia", tmd_Sach.Tmd_MaTG);
            return View(tmd_Sach);
        }

        // GET: Tmd_Sach/Delete/5
        public ActionResult TmdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_Sach tmd_Sach = db.Tmd_Sach.Find(id);
            if (tmd_Sach == null)
            {
                return HttpNotFound();
            }
            return View(tmd_Sach);
        }

        // POST: Tmd_Sach/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(string id)
        {
            Tmd_Sach tmd_Sach = db.Tmd_Sach.Find(id);
            db.Tmd_Sach.Remove(tmd_Sach);
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
