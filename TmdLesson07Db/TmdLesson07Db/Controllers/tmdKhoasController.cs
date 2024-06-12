using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLesson07Db.Models;

namespace TmdLesson07Db.Controllers
{
    public class tmdKhoasController : Controller
    {
        private TmdK22CNT4Lesson07DbEntities db = new TmdK22CNT4Lesson07DbEntities();

        // GET: tmdKhoas
        public ActionResult TmdIndex()
        {
            return View(db.tmdKhoa.ToList());
        }

        // GET: tmdKhoas/Details/5
        public ActionResult TmdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tmdKhoa tmdKhoa = db.tmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // GET: tmdKhoas/Create
        public ActionResult TmdCreate()
        {
            return View();
        }

        // POST: tmdKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "TmdKH,TmdTenKH,TmdTrangThai")] tmdKhoa tmdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.tmdKhoa.Add(tmdKhoa);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            return View(tmdKhoa);
        }

        // GET: tmdKhoas/Edit/5
        public ActionResult TmdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tmdKhoa tmdKhoa = db.tmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // POST: tmdKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "TmdKH,TmdTenKH,TmdTrangThai")] tmdKhoa tmdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            return View(tmdKhoa);
        }

        // GET: tmdKhoas/Delete/5
        public ActionResult TmdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tmdKhoa tmdKhoa = db.tmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // POST: tmdKhoas/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(string id)
        {
            tmdKhoa tmdKhoa = db.tmdKhoa.Find(id);
            db.tmdKhoa.Remove(tmdKhoa);
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
