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
    public class TINTUCsController : Controller
    {
        private MyDB db = new MyDB();

        // GET: Admin/TINTUCs
        public ActionResult Index()
        {
            var tINTUCs = db.TINTUCs.Include(t => t.NHOMTIN);
            return View(tINTUCs.ToList());
        }

        // GET: Admin/TINTUCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            return View(tINTUC);
        }

        // GET: Admin/TINTUCs/Create
        public ActionResult Create()
        {
            ViewBag.ID_NHOM = new SelectList(db.NHOMTINs, "ID_NHOM", "tennhomtin");
            return View();
        }

        // POST: Admin/TINTUCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TIN,ID_NHOM,tentin,ImgTin,mota")] TINTUC tINTUC)
        {
            if (ModelState.IsValid)
            {
                db.TINTUCs.Add(tINTUC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_NHOM = new SelectList(db.NHOMTINs, "ID_NHOM", "tennhomtin", tINTUC.ID_NHOM);
            return View(tINTUC);
        }

        // GET: Admin/TINTUCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_NHOM = new SelectList(db.NHOMTINs, "ID_NHOM", "tennhomtin", tINTUC.ID_NHOM);
            return View(tINTUC);
        }

        // POST: Admin/TINTUCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TIN,ID_NHOM,tentin,ImgTin,mota")] TINTUC tINTUC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tINTUC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_NHOM = new SelectList(db.NHOMTINs, "ID_NHOM", "tennhomtin", tINTUC.ID_NHOM);
            return View(tINTUC);
        }

        // GET: Admin/TINTUCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINTUC tINTUC = db.TINTUCs.Find(id);
            if (tINTUC == null)
            {
                return HttpNotFound();
            }
            return View(tINTUC);
        }

        // POST: Admin/TINTUCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TINTUC tINTUC = db.TINTUCs.Find(id);
            db.TINTUCs.Remove(tINTUC);
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
