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
    public class Age_DistributionController : Controller
    {
        private MelbourneMHVersion1_dbEntities db = new MelbourneMHVersion1_dbEntities();

        // GET: Age_Distribution
        public ActionResult Age_Distribution()
        {
            return View(db.Age_Distribution.ToList());
        }

        // GET: Age_Distribution/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age_Distribution age_Distribution = db.Age_Distribution.Find(id);
            if (age_Distribution == null)
            {
                return HttpNotFound();
            }
            return View(age_Distribution);
        }

        // GET: Age_Distribution/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Age_Distribution/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeId,Year,Age_Group,AgeDist_")] Age_Distribution age_Distribution)
        {
            if (ModelState.IsValid)
            {
                db.Age_Distribution.Add(age_Distribution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(age_Distribution);
        }

        // GET: Age_Distribution/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age_Distribution age_Distribution = db.Age_Distribution.Find(id);
            if (age_Distribution == null)
            {
                return HttpNotFound();
            }
            return View(age_Distribution);
        }

        // POST: Age_Distribution/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeId,Year,Age_Group,AgeDist_")] Age_Distribution age_Distribution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(age_Distribution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(age_Distribution);
        }

        // GET: Age_Distribution/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Age_Distribution age_Distribution = db.Age_Distribution.Find(id);
            if (age_Distribution == null)
            {
                return HttpNotFound();
            }
            return View(age_Distribution);
        }

        // POST: Age_Distribution/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Age_Distribution age_Distribution = db.Age_Distribution.Find(id);
            db.Age_Distribution.Remove(age_Distribution);
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
