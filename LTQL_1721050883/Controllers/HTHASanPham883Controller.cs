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
    public class HTHASanPham883Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: HTHASanPham883
        public ActionResult Index()
        {
            var hTHASanPham883s = db.HTHASanPham883s.Include(h => h.NhaCungCap883s);
            return View(hTHASanPham883s.ToList());
        }

        // GET: HTHASanPham883/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HTHASanPham883 hTHASanPham883 = db.HTHASanPham883s.Find(id);
            if (hTHASanPham883 == null)
            {
                return HttpNotFound();
            }
            return View(hTHASanPham883);
        }

        // GET: HTHASanPham883/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap883s, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: HTHASanPham883/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] HTHASanPham883 hTHASanPham883)
        {
            if (ModelState.IsValid)
            {
                db.HTHASanPham883s.Add(hTHASanPham883);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap883s, "MaNhaCungCap", "TenNhaCungCap", hTHASanPham883.MaNhaCungCap);
            return View(hTHASanPham883);
        }

        // GET: HTHASanPham883/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HTHASanPham883 hTHASanPham883 = db.HTHASanPham883s.Find(id);
            if (hTHASanPham883 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap883s, "MaNhaCungCap", "TenNhaCungCap", hTHASanPham883.MaNhaCungCap);
            return View(hTHASanPham883);
        }

        // POST: HTHASanPham883/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] HTHASanPham883 hTHASanPham883)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hTHASanPham883).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap883s, "MaNhaCungCap", "TenNhaCungCap", hTHASanPham883.MaNhaCungCap);
            return View(hTHASanPham883);
        }

        // GET: HTHASanPham883/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HTHASanPham883 hTHASanPham883 = db.HTHASanPham883s.Find(id);
            if (hTHASanPham883 == null)
            {
                return HttpNotFound();
            }
            return View(hTHASanPham883);
        }

        // POST: HTHASanPham883/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HTHASanPham883 hTHASanPham883 = db.HTHASanPham883s.Find(id);
            db.HTHASanPham883s.Remove(hTHASanPham883);
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
