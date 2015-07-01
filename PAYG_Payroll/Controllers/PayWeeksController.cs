﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PAYG_Payroll.Models;

namespace PAYG_Payroll.Controllers
{
    [Authorize]
    public class PayWeeksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

    
        
        public ActionResult Index()
        {

            return View(db.PayWeeks.ToList());
        }

        // GET: PayWeeks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayWeeks payWeeks = db.PayWeeks.Find(id);
            if (payWeeks == null)
            {
                return HttpNotFound();
            }
            return View(payWeeks);
        }

        // GET: PayWeeks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayWeeks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StartDate,EndDate,PayDate,Year,WeekNumber,RotaWeek,IsProcessed,Branch")] PayWeeks payWeeks)
        {
            if (ModelState.IsValid)
            {
                db.PayWeeks.Add(payWeeks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payWeeks);
        }

        // GET: PayWeeks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayWeeks payWeeks = db.PayWeeks.Find(id);
            if (payWeeks == null)
            {
                return HttpNotFound();
            }
            return View(payWeeks);
        }

        // POST: PayWeeks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StartDate,EndDate,PayDate,Year,WeekNumber,RotaWeek,IsProcessed,Branch")] PayWeeks payWeeks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payWeeks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payWeeks);
        }

        // GET: PayWeeks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayWeeks payWeeks = db.PayWeeks.Find(id);
            if (payWeeks == null)
            {
                return HttpNotFound();
            }
            return View(payWeeks);
        }

        // POST: PayWeeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayWeeks payWeeks = db.PayWeeks.Find(id);
            db.PayWeeks.Remove(payWeeks);
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
