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
    public class Melbourne_PopulationController : Controller
    {
        private MelbourneMHVersion1_dbEntities db = new MelbourneMHVersion1_dbEntities();

        // GET: Melbourne_Population
        public ActionResult Melbourne_Population()
        {
            return View(db.Melbourne_Population.ToList());
        }

        // GET: Melbourne_Population/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Melbourne_Population melbourne_Population = db.Melbourne_Population.Find(id);
            if (melbourne_Population == null)
            {
                return HttpNotFound();
            }
            return View(melbourne_Population);
        }

        // GET: Melbourne_Population/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Melbourne_Population/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeId,Year,Mel_Population")] Melbourne_Population melbourne_Population)
        {
            if (ModelState.IsValid)
            {
                db.Melbourne_Population.Add(melbourne_Population);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(melbourne_Population);
        }

        // GET: Melbourne_Population/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Melbourne_Population melbourne_Population = db.Melbourne_Population.Find(id);
            if (melbourne_Population == null)
            {
                return HttpNotFound();
            }
            return View(melbourne_Population);
        }

        // POST: Melbourne_Population/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeId,Year,Mel_Population")] Melbourne_Population melbourne_Population)
        {
            if (ModelState.IsValid)
            {
                db.Entry(melbourne_Population).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(melbourne_Population);
        }

        // GET: Melbourne_Population/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Melbourne_Population melbourne_Population = db.Melbourne_Population.Find(id);
            if (melbourne_Population == null)
            {
                return HttpNotFound();
            }
            return View(melbourne_Population);
        }

        // POST: Melbourne_Population/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Melbourne_Population melbourne_Population = db.Melbourne_Population.Find(id);
            db.Melbourne_Population.Remove(melbourne_Population);
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
