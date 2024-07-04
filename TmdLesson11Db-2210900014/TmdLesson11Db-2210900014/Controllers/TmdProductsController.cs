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
    public class TmdProductsController : Controller
    {
        private TmdK22CNT4Lesson11DbEntities db = new TmdK22CNT4Lesson11DbEntities();

        // GET: TmdProducts
        public ActionResult TmdIndex()
        {
            var tmdProduct = db.TmdProduct.Include(t => t.TmdCategory);
            return View(tmdProduct.ToList());
        }

        // GET: TmdProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProduct.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            return View(tmdProduct);
        }

        // GET: TmdProducts/Create
        public ActionResult Create()
        {
            ViewBag.TmdCateId = new SelectList(db.TmdCategory, "TmdID", "TmdCateName");
            return View();
        }

        // POST: TmdProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdId2210900014,TmdProName,TmdQty,TmdPrice,TmdCateId,TmdActive")] TmdProduct tmdProduct)
        {
            if (ModelState.IsValid)
            {
                db.TmdProduct.Add(tmdProduct);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            ViewBag.TmdCateId = new SelectList(db.TmdCategory, "TmdID", "TmdCateName", tmdProduct.TmdCateId);
            return View(tmdProduct);
        }

        // GET: TmdProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProduct.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.TmdCateId = new SelectList(db.TmdCategory, "TmdID", "TmdCateName", tmdProduct.TmdCateId);
            return View(tmdProduct);
        }

        // POST: TmdProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdId2210900014,TmdProName,TmdQty,TmdPrice,TmdCateId,TmdActive")] TmdProduct tmdProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            ViewBag.TmdCateId = new SelectList(db.TmdCategory, "TmdID", "TmdCateName", tmdProduct.TmdCateId);
            return View(tmdProduct);
        }

        // GET: TmdProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProduct.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            return View(tmdProduct);
        }

        // POST: TmdProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TmdProduct tmdProduct = db.TmdProduct.Find(id);
            db.TmdProduct.Remove(tmdProduct);
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
