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
    public class Add_OnsController : Controller
    {
        private MaggiewalaContext db = new MaggiewalaContext();

        // GET: Add_Ons
        public ActionResult Index()
        {
            return View(db.Add_Ons.ToList());
        }

        // GET: Add_Ons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add_Ons add_Ons = db.Add_Ons.Find(id);
            if (add_Ons == null)
            {
                return HttpNotFound();
            }
            return View(add_Ons);
        }

        // GET: Add_Ons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Add_Ons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Item,Image,Price")] Add_Ons add_Ons)
        {
            if (ModelState.IsValid)
            {
                db.Add_Ons.Add(add_Ons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(add_Ons);
        }

        // GET: Add_Ons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add_Ons add_Ons = db.Add_Ons.Find(id);
            if (add_Ons == null)
            {
                return HttpNotFound();
            }
            return View(add_Ons);
        }

        // POST: Add_Ons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Item,Image,Price")] Add_Ons add_Ons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(add_Ons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(add_Ons);
        }

        // GET: Add_Ons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add_Ons add_Ons = db.Add_Ons.Find(id);
            if (add_Ons == null)
            {
                return HttpNotFound();
            }
            return View(add_Ons);
        }

        // POST: Add_Ons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Add_Ons add_Ons = db.Add_Ons.Find(id);
            db.Add_Ons.Remove(add_Ons);
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
