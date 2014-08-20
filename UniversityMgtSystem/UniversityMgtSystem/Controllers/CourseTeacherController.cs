using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityMgtSystem.Models;

namespace UniversityMgtSystem.Controllers
{
    public class CourseTeacherController : Controller
    {
        private ProjectDb db = new ProjectDb();

        // GET: /CourseTeacher/
        public ActionResult Index()
        {
            var courseteachers = db.CourseTeachers.Include(c => c.Course).Include(c => c.Department).Include(c => c.Teacher);
            return View(courseteachers.ToList());
        }

        // GET: /CourseTeacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTeacher courseteacher = db.CourseTeachers.Find(id);
            if (courseteacher == null)
            {
                return HttpNotFound();
            }
            return View(courseteacher);
        }

        // GET: /CourseTeacher/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name");
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name");
            return View();
        }

        // POST: /CourseTeacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourseTeacherId,DepartmentId,TeacherId,CourseId")] CourseTeacher courseteacher)
        {
            if (ModelState.IsValid)
            {
                db.CourseTeachers.Add(courseteacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseteacher.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseteacher.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseteacher.TeacherId);
            return View(courseteacher);
        }

        // GET: /CourseTeacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTeacher courseteacher = db.CourseTeachers.Find(id);
            if (courseteacher == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseteacher.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseteacher.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseteacher.TeacherId);
            return View(courseteacher);
        }

        // POST: /CourseTeacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CourseTeacherId,DepartmentId,TeacherId,CourseId")] CourseTeacher courseteacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseteacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseteacher.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseteacher.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseteacher.TeacherId);
            return View(courseteacher);
        }

        // GET: /CourseTeacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseTeacher courseteacher = db.CourseTeachers.Find(id);
            if (courseteacher == null)
            {
                return HttpNotFound();
            }
            return View(courseteacher);
        }

        // POST: /CourseTeacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseTeacher courseteacher = db.CourseTeachers.Find(id);
            db.CourseTeachers.Remove(courseteacher);
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
