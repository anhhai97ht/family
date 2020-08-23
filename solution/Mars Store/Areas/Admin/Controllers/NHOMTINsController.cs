using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mars_Store.Models.Entities;

namespace Mars_Store.Areas.Admin.Controllers
{
    public class NHOMTINsController : Controller
    {
        private MyDB db = new MyDB();

        // GET: Admin/NHOMTINs
        public ActionResult Index()
        {
            return View(db.NHOMTINs.ToList());
        }

        // GET: Admin/NHOMTINs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMTIN nHOMTIN = db.NHOMTINs.Find(id);
            if (nHOMTIN == null)
            {
                return HttpNotFound();
            }
            return View(nHOMTIN);
        }

        // GET: Admin/NHOMTINs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NHOMTINs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_NHOM,tennhomtin")] NHOMTIN nHOMTIN)
        {
            if (ModelState.IsValid)
            {
                db.NHOMTINs.Add(nHOMTIN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nHOMTIN);
        }

        // GET: Admin/NHOMTINs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMTIN nHOMTIN = db.NHOMTINs.Find(id);
            if (nHOMTIN == null)
            {
                return HttpNotFound();
            }
            return View(nHOMTIN);
        }

        // POST: Admin/NHOMTINs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_NHOM,tennhomtin")] NHOMTIN nHOMTIN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHOMTIN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nHOMTIN);
        }

        // GET: Admin/NHOMTINs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMTIN nHOMTIN = db.NHOMTINs.Find(id);
            if (nHOMTIN == null)
            {
                return HttpNotFound();
            }
            return View(nHOMTIN);
        }

        // POST: Admin/NHOMTINs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NHOMTIN nHOMTIN = db.NHOMTINs.Find(id);
            db.NHOMTINs.Remove(nHOMTIN);
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
