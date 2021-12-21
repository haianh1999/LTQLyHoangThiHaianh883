using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050883.Models;

namespace LTQL_1721050883.Controllers
{
    public class NhaCungCap883Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: NhaCungCap883
        public ActionResult Index()
        {
            return View(db.NhaCungCap883s.ToList());
        }

        // GET: NhaCungCap883/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap883 nhaCungCap883 = db.NhaCungCap883s.Find(id);
            if (nhaCungCap883 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap883);
        }

        // GET: NhaCungCap883/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap883/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap883 nhaCungCap883)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap883s.Add(nhaCungCap883);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap883);
        }

        // GET: NhaCungCap883/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap883 nhaCungCap883 = db.NhaCungCap883s.Find(id);
            if (nhaCungCap883 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap883);
        }

        // POST: NhaCungCap883/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap883 nhaCungCap883)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap883).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap883);
        }

        // GET: NhaCungCap883/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap883 nhaCungCap883 = db.NhaCungCap883s.Find(id);
            if (nhaCungCap883 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap883);
        }

        // POST: NhaCungCap883/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap883 nhaCungCap883 = db.NhaCungCap883s.Find(id);
            db.NhaCungCap883s.Remove(nhaCungCap883);
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
