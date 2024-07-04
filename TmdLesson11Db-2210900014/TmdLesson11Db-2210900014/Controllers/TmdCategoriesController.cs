using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLesson11Db_2210900014.Models;

namespace TmdLesson11Db_2210900014.Controllers
{
    public class TmdCategoriesController : Controller
    {
        private TmdK22CNT4Lesson11DbEntities db = new TmdK22CNT4Lesson11DbEntities();

        // GET: TmdCategories
        public ActionResult TmdIndex()
        {
            return View(db.TmdCategory.ToList());
        }

        // GET: TmdCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdCategory tmdCategory = db.TmdCategory.Find(id);
            if (tmdCategory == null)
            {
                return HttpNotFound();
            }
            return View(tmdCategory);
        }

        // GET: TmdCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TmdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdID,TmdCateName,TmdStatus")] TmdCategory tmdCategory)
        {
            if (ModelState.IsValid)
            {
                db.TmdCategory.Add(tmdCategory);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            return View(tmdCategory);
        }

        // GET: TmdCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdCategory tmdCategory = db.TmdCategory.Find(id);
            if (tmdCategory == null)
            {
                return HttpNotFound();
            }
            return View(tmdCategory);
        }

        // POST: TmdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdID,TmdCateName,TmdStatus")] TmdCategory tmdCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            return View(tmdCategory);
        }

        // GET: TmdCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdCategory tmdCategory = db.TmdCategory.Find(id);
            if (tmdCategory == null)
            {
                return HttpNotFound();
            }
            return View(tmdCategory);
        }

        // POST: TmdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TmdCategory tmdCategory = db.TmdCategory.Find(id);
            db.TmdCategory.Remove(tmdCategory);
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
