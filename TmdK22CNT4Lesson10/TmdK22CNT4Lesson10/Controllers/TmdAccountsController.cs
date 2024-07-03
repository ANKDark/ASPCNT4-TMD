using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TmdK22CNT4Lesson10.Models;

namespace TmdK22CNT4Lesson10.Controllers
{
    public class TmdAccountsController : Controller
    {
        private TmdK22CNT4Lesson10DbEntities db = new TmdK22CNT4Lesson10DbEntities();

        // GET: TmdAccounts
        public ActionResult Index()
        {
            return View(db.TmdAccount.ToList());
        }

        // GET: TmdAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdAccount tmdAccount = db.TmdAccount.Find(id);
            if (tmdAccount == null)
            {
                return HttpNotFound();
            }
            return View(tmdAccount);
        }

        // GET: TmdAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TmdAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TmdID,TmdUserName,TmdPassword,TmdFullName,TmdEmail,TmdPhone,TmdActive")] TmdAccount tmdAccount)
        {
            if (ModelState.IsValid)
            {
                db.TmdAccount.Add(tmdAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tmdAccount);
        }

        // GET: TmdAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdAccount tmdAccount = db.TmdAccount.Find(id);
            if (tmdAccount == null)
            {
                return HttpNotFound();
            }
            return View(tmdAccount);
        }

        // POST: TmdAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TmdID,TmdUserName,TmdPassword,TmdFullName,TmdEmail,TmdPhone,TmdActive")] TmdAccount tmdAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tmdAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tmdAccount);
        }

        // GET: TmdAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TmdAccount tmdAccount = db.TmdAccount.Find(id);
            if (tmdAccount == null)
            {
                return HttpNotFound();
            }
            return View(tmdAccount);
        }

        // POST: TmdAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TmdAccount tmdAccount = db.TmdAccount.Find(id);
            db.TmdAccount.Remove(tmdAccount);
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

        //Login
        public ActionResult TmdLogin()
        {
            var tmdModel = new TmdAccount(); 
            return View(tmdModel);
        }
        [HttpPost]
        public ActionResult TmdLogin(TmdAccount tmdAccount) 
        {
            var tmdCheck = db.TmdAccount.Where(x => x.TmdUserName.Equals(tmdAccount.TmdUserName) && x.TmdPassword.Equals(tmdAccount.TmdPassword)).FirstOrDefault();
            if (tmdCheck != null) 
            {
                Session["TmdAccount"] = tmdCheck;
                return Redirect("/");
            }
            return View();
        }
    }
}
