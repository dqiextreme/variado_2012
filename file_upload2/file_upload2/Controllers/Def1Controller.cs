using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using file_upload2.Models;

namespace file_upload2.Controllers
{
    public class Def1Controller : Controller
    {
        private test_linqsql1Entities db = new test_linqsql1Entities();

        //
        // GET: /Def1/

        public ActionResult Index()
        {
            return View(db.Adjunto.ToList());
        }

        //
        // GET: /Def1/Details/5

        public ActionResult Details(int id = 0)
        {
            Adjunto adjunto = db.Adjunto.Find(id);
            if (adjunto == null)
            {
                return HttpNotFound();
            }
            return View(adjunto);
        }

        //
        // GET: /Def1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Def1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Adjunto adjunto)
        {
            if (ModelState.IsValid)
            {
                db.Adjunto.Add(adjunto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adjunto);
        }

        //
        // GET: /Def1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Adjunto adjunto = db.Adjunto.Find(id);
            if (adjunto == null)
            {
                return HttpNotFound();
            }
            return View(adjunto);
        }

        //
        // POST: /Def1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Adjunto adjunto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adjunto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adjunto);
        }

        //
        // GET: /Def1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Adjunto adjunto = db.Adjunto.Find(id);
            if (adjunto == null)
            {
                return HttpNotFound();
            }
            return View(adjunto);
        }

        //
        // POST: /Def1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adjunto adjunto = db.Adjunto.Find(id);
            db.Adjunto.Remove(adjunto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}