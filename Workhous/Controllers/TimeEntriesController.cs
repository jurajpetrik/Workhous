using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Workhous.Models;

namespace Workhous.Controllers
{
    public class TimeEntriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TimeEntries/Create/1
        public ActionResult Create(int projectId, string projectName)
        {
            TimeEntry timeEntry = new TimeEntry();
            timeEntry.ProjectID = projectId;
            return View(new ProjectTimeEntry(projectName,timeEntry));
        }

        // POST: TimeEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectTimeEntry ProjectTimeEntry)
        {
            if (ModelState.IsValid)
            {
                db.TimeEntries.Add(ProjectTimeEntry.TimeEntry);
                db.SaveChanges();
                return RedirectToProjectDetailsContainingTimeEntry(ProjectTimeEntry.TimeEntry);          
            }

            return View(ProjectTimeEntry.TimeEntry);
        }

        // GET: TimeEntries/Delete/5
        public ActionResult Delete(int? id, int projectId, string projectName)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeEntry timeEntry = db.TimeEntries.Find(id);
            if (timeEntry == null)
            {
                return HttpNotFound();
            }
            return View(new ProjectTimeEntry(projectName, timeEntry));
        }

        // POST: TimeEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeEntry timeEntry = db.TimeEntries.Find(id);
            db.TimeEntries.Remove(timeEntry);
            db.SaveChanges();
            return RedirectToProjectDetailsContainingTimeEntry(timeEntry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private ActionResult RedirectToProjectDetailsContainingTimeEntry(TimeEntry timeEntry)
        {
            return RedirectToAction("Details", "Projects", new { id = timeEntry.ProjectID, month = timeEntry.Day });
        }
    }
}
