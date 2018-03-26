using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DVDStore.DataBase.Models;

namespace DVDStore.Web.Controllers
{
    public class DVDsController : Controller
    {
        private DVDDB db = new DVDDB();

        // GET: DVDs
        public ActionResult Index()
        {
            /*
             //PsuedoCode:
             DataBaseAccessClass dbaccess = new DatabaseAccessClass();
             var result = dbaccess.GetAllDVDs();
             return View(result);
             */

            return View(db.DVDs.ToList());
        }

        // GET: DVDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD dVD = db.DVDs.Find(id);
            if (dVD == null)
            {
                return HttpNotFound();
            }
            return View(dVD);
        }

        // GET: DVDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DVDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Genre,TimeLength,Language,Rating,Sold,Price,Image")] DVD dVD)
        {
            if (ModelState.IsValid)
            {
                db.DVDs.Add(dVD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dVD);
        }

        // GET: DVDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD dVD = db.DVDs.Find(id);
            if (dVD == null)
            {
                return HttpNotFound();
            }
            return View(dVD);
        }

        // POST: DVDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Genre,TimeLength,Language,Rating,Sold,Price,Image")] DVD dVD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dVD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dVD);
        }

        // GET: DVDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD dVD = db.DVDs.Find(id);
            if (dVD == null)
            {
                return HttpNotFound();
            }
            return View(dVD);
        }

        // POST: DVDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DVD dVD = db.DVDs.Find(id);
            db.DVDs.Remove(dVD);
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
