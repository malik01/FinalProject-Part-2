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
    public class StartersController : Controller
    {
        private MaggiewalaContext db = new MaggiewalaContext();

        // GET: Starters
        public ActionResult Index()
        {
            return View(db.Starters.ToList());
        }

        // GET: Starters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Starter starter = db.Starters.Find(id);
            if (starter == null)
            {
                return HttpNotFound();
            }
            return View(starter);
        }

        // GET: Starters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Starters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Item,Description,Image,Price")] Starter starter)
        {
            if (ModelState.IsValid)
            {
                db.Starters.Add(starter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(starter);
        }

        // GET: Starters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Starter starter = db.Starters.Find(id);
            if (starter == null)
            {
                return HttpNotFound();
            }
            return View(starter);
        }

        // POST: Starters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Item,Description,Image,Price")] Starter starter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(starter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(starter);
        }

        // GET: Starters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Starter starter = db.Starters.Find(id);
            if (starter == null)
            {
                return HttpNotFound();
            }
            return View(starter);
        }

        // POST: Starters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Starter starter = db.Starters.Find(id);
            db.Starters.Remove(starter);
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
