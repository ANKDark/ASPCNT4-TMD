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
    public class TmdMonHocsController : Controller
    {
        private tmd_qlsinhvienEntities db = new tmd_qlsinhvienEntities();

        // GET: TmdMonHocs
        public ActionResult TmdIndex()
        {
            return View(db.TmdMonHoc.ToList());
        }

        // GET: TmdMonHocs/Details/5
        public ActionResult TmdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdMonHoc tmdMonHoc = db.TmdMonHoc.Find(id);
            if (tmdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tmdMonHoc);
        }

        // GET: TmdMonHocs/Create
        public ActionResult TmdCreate()
        {
            return View();
        }

        // POST: TmdMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "TmdMaMH,TmdTenMH,TmdSotiet")] TmdMonHoc tmdMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.TmdMonHoc.Add(tmdMonHoc);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            return View(tmdMonHoc);
        }

        // GET: TmdMonHocs/Edit/5
        public ActionResult TmdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdMonHoc tmdMonHoc = db.TmdMonHoc.Find(id);
            if (tmdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tmdMonHoc);
        }

        // POST: TmdMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "TmdMaMH,TmdTenMH,TmdSotiet")] TmdMonHoc tmdMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            return View(tmdMonHoc);
        }

        // GET: TmdMonHocs/Delete/5
        public ActionResult TmdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdMonHoc tmdMonHoc = db.TmdMonHoc.Find(id);
            if (tmdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(tmdMonHoc);
        }

        // POST: TmdMonHocs/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(string id)
        {
            TmdMonHoc tmdMonHoc = db.TmdMonHoc.Find(id);
            db.TmdMonHoc.Remove(tmdMonHoc);
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
