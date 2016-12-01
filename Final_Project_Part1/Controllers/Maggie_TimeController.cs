using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final_Project_Part1.Models;

namespace Final_Project_Part1.Controllers
{
    public class Maggie_TimeController : Controller
    {
        private MaggiewalaContext db = new MaggiewalaContext();

        // GET: Maggie_Time
        public ActionResult Index()
        {
            return View(db.Maggie_Time.ToList());
        }

        // GET: Maggie_Time/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maggie_Time maggie_Time = db.Maggie_Time.Find(id);
            if (maggie_Time == null)
            {
                return HttpNotFound();
            }
            return View(maggie_Time);
        }

        // GET: Maggie_Time/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maggie_Time/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Item,Description,Image,Price")] Maggie_Time maggie_Time)
        {
            if (ModelState.IsValid)
            {
                db.Maggie_Time.Add(maggie_Time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maggie_Time);
        }

        // GET: Maggie_Time/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maggie_Time maggie_Time = db.Maggie_Time.Find(id);
            if (maggie_Time == null)
            {
                return HttpNotFound();
            }
            return View(maggie_Time);
        }

        // POST: Maggie_Time/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Item,Description,Image,Price")] Maggie_Time maggie_Time)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maggie_Time).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maggie_Time);
        }

        // GET: Maggie_Time/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maggie_Time maggie_Time = db.Maggie_Time.Find(id);
            if (maggie_Time == null)
            {
                return HttpNotFound();
            }
            return View(maggie_Time);
        }

        // POST: Maggie_Time/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maggie_Time maggie_Time = db.Maggie_Time.Find(id);
            db.Maggie_Time.Remove(maggie_Time);
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
