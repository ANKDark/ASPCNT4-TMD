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
    public class TmdKhoasController : Controller
    {
        private tmd_qlsinhvienEntities db = new tmd_qlsinhvienEntities();

        // GET: TmdKhoas
        public ActionResult Index()
        {
            return View(db.TmdKhoa.ToList());
        }

        // GET: TmdKhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKhoa tmdKhoa = db.TmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // GET: TmdKhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TmdKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdMaKH,TmdTenKH")] TmdKhoa tmdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.TmdKhoa.Add(tmdKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tmdKhoa);
        }

        // GET: TmdKhoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKhoa tmdKhoa = db.TmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // POST: TmdKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdMaKH,TmdTenKH")] TmdKhoa tmdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tmdKhoa);
        }

        // GET: TmdKhoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdKhoa tmdKhoa = db.TmdKhoa.Find(id);
            if (tmdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tmdKhoa);
        }

        // POST: TmdKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TmdKhoa tmdKhoa = db.TmdKhoa.Find(id);
            db.TmdKhoa.Remove(tmdKhoa);
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
