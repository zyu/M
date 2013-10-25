using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M.Models;

namespace M.Controllers
{
    public class AreasController : Controller
    {
        private LaderContext db = new LaderContext();

        //
        // GET: /Areas/

        public ActionResult Index()
        {
            return View(db.AREAS.ToList());
        }

        //
        // GET: /Areas/Details/5

        public ActionResult Details(int id = 0)
        {
            AREAS areas = db.AREAS.Find(id);
            if (areas == null)
            {
                return HttpNotFound();
            }
            return View(areas);
        }

        //
        // GET: /Areas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Areas/Create

        [HttpPost]
        public ActionResult Create(AREAS areas)
        {
            if (ModelState.IsValid)
            {
                db.AREAS.Add(areas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(areas);
        }

        //
        // GET: /Areas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AREAS areas = db.AREAS.Find(id);
            if (areas == null)
            {
                return HttpNotFound();
            }
            return View(areas);
        }

        //
        // POST: /Areas/Edit/5

        [HttpPost]
        public ActionResult Edit(AREAS areas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(areas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(areas);
        }

        //
        // GET: /Areas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AREAS areas = db.AREAS.Find(id);
            if (areas == null)
            {
                return HttpNotFound();
            }
            return View(areas);
        }

         
        //
        // POST: /Areas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AREAS areas = db.AREAS.Find(id);
            db.AREAS.Remove(areas);
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