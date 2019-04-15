using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MelbourneMH.Models;

namespace MelbourneMH.Controllers
{
    public class Suburb_PopulationController : Controller
    {
        private MelbourneMHVersion1_dbEntities db = new MelbourneMHVersion1_dbEntities();

        // GET: Suburb_Population
        public ActionResult Suburb_Population()
        {
            return View(db.Suburb_Population.ToList());
            
        }

        // GET: Suburb_Population/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suburb_Population suburb_Population = db.Suburb_Population.Find(id);
            if (suburb_Population == null)
            {
                return HttpNotFound();
            }
            return View(suburb_Population);
        }

        // GET: Suburb_Population/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suburb_Population/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeId,Year,Suburb_Name,Suburb_Population1")] Suburb_Population suburb_Population)
        {
            if (ModelState.IsValid)
            {
                db.Suburb_Population.Add(suburb_Population);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suburb_Population);
        }

        // GET: Suburb_Population/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suburb_Population suburb_Population = db.Suburb_Population.Find(id);
            if (suburb_Population == null)
            {
                return HttpNotFound();
            }
            return View(suburb_Population);
        }

        // POST: Suburb_Population/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeId,Year,Suburb_Name,Suburb_Population1")] Suburb_Population suburb_Population)
        {
            if (ModelState.IsValid)
            {
                db.Entry(suburb_Population).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suburb_Population);
        }

        // GET: Suburb_Population/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suburb_Population suburb_Population = db.Suburb_Population.Find(id);
            if (suburb_Population == null)
            {
                return HttpNotFound();
            }
            return View(suburb_Population);
        }

        // POST: Suburb_Population/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Suburb_Population suburb_Population = db.Suburb_Population.Find(id);
            db.Suburb_Population.Remove(suburb_Population);
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
