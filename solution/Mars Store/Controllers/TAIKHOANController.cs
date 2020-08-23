using Mars_Store.fonts.Models.Function;
using Mars_Store.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Mars_Store.Controllers
{
    public class TAIKHOANsController : Controller
    {
        private MyDB db = new MyDB();
        //
        // GET: /TAIKHOAN/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /TAIKHOAN/Details/5
        public ActionResult Details()
        {
            return View();
        }
        //
        // GET: /TAIKHOAN/Create
        public ActionResult Create()
        {

            return View();

        }

        //
        // POST: /TAIKHOAN/Create
        [HttpPost]
        public ActionResult Create(TAIKHOAN model)
        {
            try
            {
                // TODO: Add insert logic here
                var result = new TAIKHOANFunction.TaiKhoanFunction().Insert(model);
                if (result == 0)
                {
                    return View();
                }
                return RedirectToAction("Index", "UserLogin");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create2(TAIKHOAN model)
        {
            try
            {
                // TODO: Add insert logic here
                var result = new TAIKHOANFunction.TaiKhoanFunction().Insert(model);
                if (result == 0)
                {
                    return View();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TAIKHOAN/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        //
        // POST: /TAIKHOAN/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TAIKHOAN/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TAIKHOAN/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
