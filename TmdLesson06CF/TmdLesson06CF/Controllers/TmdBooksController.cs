using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLesson06CF.Models;

namespace TmdLesson06CF.Controllers
{
    public class TmdBooksController : Controller
    {
        private TmdBookStore db = new TmdBookStore();

        // GET: TmdBooks
        public ActionResult Index()
        {
            return View(db.TmdBooks.ToList());
        }

        // GET: TmdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdBook tmdBook = db.TmdBooks.Find(id);
            if (tmdBook == null)
            {
                return HttpNotFound();
            }
            return View(tmdBook);
        }

        // GET: TmdBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TmdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdId,TmdBookId,TmdTitle,TmdAuthor,TmdYear,TmdPublic,TmdPicture,TmdCategoryId")] TmdBook tmdBook)
        {
            if (ModelState.IsValid)
            {
                db.TmdBooks.Add(tmdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tmdBook);
        }

        // GET: TmdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdBook tmdBook = db.TmdBooks.Find(id);
            if (tmdBook == null)
            {
                return HttpNotFound();
            }
            return View(tmdBook);
        }

        // POST: TmdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdId,TmdBookId,TmdTitle,TmdAuthor,TmdYear,TmdPublic,TmdPicture,TmdCategoryId")] TmdBook tmdBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tmdBook);
        }

        // GET: TmdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdBook tmdBook = db.TmdBooks.Find(id);
            if (tmdBook == null)
            {
                return HttpNotFound();
            }
            return View(tmdBook);
        }

        // POST: TmdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TmdBook tmdBook = db.TmdBooks.Find(id);
            db.TmdBooks.Remove(tmdBook);
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
