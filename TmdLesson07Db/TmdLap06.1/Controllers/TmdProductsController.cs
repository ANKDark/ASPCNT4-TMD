using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdLap06._1.Models;

namespace TmdLap06._1.Controllers
{
    public class TmdProductsController : Controller
    {
        private TmdShopContext db = new TmdShopContext();

        // GET: TmdProducts
        public ActionResult TmdIndex()
        {
            return View(db.TmdProducts.ToList());
        }

        // GET: TmdProducts/Details/5
        public ActionResult TmdDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProducts.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            return View(tmdProduct);
        }

        // GET: TmdProducts/Create
        public ActionResult TmdCreate()
        {
            return View();
        }

        // POST: TmdProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdCreate([Bind(Include = "TmdProductId,TmdProductName,TmdPrice")] TmdProduct tmdProduct)
        {
            if (ModelState.IsValid)
            {
                db.TmdProducts.Add(tmdProduct);
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }

            return View(tmdProduct);
        }

        // GET: TmdProducts/Edit/5
        public ActionResult TmdEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProducts.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            return View(tmdProduct);
        }

        // POST: TmdProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TmdEdit([Bind(Include = "TmdProductId,TmdProductName,TmdPrice")] TmdProduct tmdProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TmdIndex");
            }
            return View(tmdProduct);
        }

        // GET: TmdProducts/Delete/5
        public ActionResult TmdDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdProduct tmdProduct = db.TmdProducts.Find(id);
            if (tmdProduct == null)
            {
                return HttpNotFound();
            }
            return View(tmdProduct);
        }

        // POST: TmdProducts/Delete/5
        [HttpPost, ActionName("TmdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TmdDeleteConfirmed(int id)
        {
            TmdProduct tmdProduct = db.TmdProducts.Find(id);
            db.TmdProducts.Remove(tmdProduct);
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
