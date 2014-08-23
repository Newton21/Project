using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystem.Models;
using UniversityManagementSystem.ViewModel;

namespace UniversityManagementSystem.Controllers
{
    public class AjaxCallController : Controller
    {

        private ProjectDb db = new ProjectDb();
       
        public ActionResult CourseDepartmentInfo(int DepartmentId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            //var info = from c in db.Courses 
            // where c.DepartmentId == DepartmentId  select new DepartmentCourseSemsterInfo(){Code = c.Code,Name = c.Name,Semester = c.Semester.Name,TeacherName =c.CourseTeachers.}

            //var info = db.Courses.Where(x=>x.DepartmentId==DepartmentId).Select(x=>new DepartmentCourseSemsterInfo()
            //{
            //    Code = x.Code,Name = x.Name,Semester = x.Semester.Name,TeacherName = x.CourseTeachers.
            //})

            var course = from c in db.Courses
                             join cT in db.TeacherCourseAssigns on c equals cT.Course into cTs
                             from cT in cTs.DefaultIfEmpty()
                             where c.DepartmentId == DepartmentId
                             select new DepartmentCourseSemester()
                             {
                                 Code = c.Code,
                                 Name = c.Name,
                                 Semester = c.Semester.Name,
                                 TeacherName = cT.Teacher.Name ?? "not assign yet"
                             };
            return Json(course, JsonRequestBehavior.AllowGet);
        }
    }
}