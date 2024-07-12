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
    public class Tmd_TacGiaController : Controller
    {
        private TranMinhDuc_2210900014Entities1 db = new TranMinhDuc_2210900014Entities1();

        // GET: Tmd_TacGia
        public ActionResult TmdIndex()
        {
            return View(db.Tmd_TacGia.ToList());
        }

        // GET: Tmd_TacGia/Details/5
        public ActionResult TmdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_TacGia tmd_TacGia = db.Tmd_TacGia.Find(id);
            if (tmd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(tmd_TacGia);
        }

        // GET: Tmd_TacGia/Create
        public ActionResult TmdCreate()
        {
            return View();
        }

        // POST: Tmd_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "Tmd_MaTG,Tmd_TenTacGia")] Tmd_TacGia tmd_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Tmd_TacGia.Add(tmd_TacGia);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            return View(tmd_TacGia);
        }

        // GET: Tmd_TacGia/Edit/5
        public ActionResult TmdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_TacGia tmd_TacGia = db.Tmd_TacGia.Find(id);
            if (tmd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(tmd_TacGia);
        }

        // POST: Tmd_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "Tmd_MaTG,Tmd_TenTacGia")] Tmd_TacGia tmd_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmd_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            return View(tmd_TacGia);
        }

        // GET: Tmd_TacGia/Delete/5
        public ActionResult TmdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tmd_TacGia tmd_TacGia = db.Tmd_TacGia.Find(id);
            if (tmd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(tmd_TacGia);
        }

        // POST: Tmd_TacGia/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(string id)
        {
            Tmd_TacGia tmd_TacGia = db.Tmd_TacGia.Find(id);
            db.Tmd_TacGia.Remove(tmd_TacGia);
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
