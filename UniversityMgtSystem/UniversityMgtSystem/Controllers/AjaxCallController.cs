using System.EnterpriseServices;
using System.Linq;
using System.Web.Mvc;
using UniversityMgtSystem.Models;
using UniversityMgtSystem.ViewModel;

namespace UniversityMgtSystem.Controllers
{
    public class AjaxCallController : Controller
    {

        private ProjectDB db = new ProjectDB();

        public ActionResult GetCourseInfo(int CourseId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var CourseInfo = db.Courses.FirstOrDefault(u => u.CourseId == CourseId);
            return Json(CourseInfo, JsonRequestBehavior.AllowGet);

        }

        public ActionResult TeacherCourseInfo(int TeacherId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            var user = db.CourseTeachers.FirstOrDefault(u => u.TeacherId == TeacherId);

            if (user == null)
            {
                var infos =
                    db.Teachers.Where(x => x.TeacherId == TeacherId)
                        .Select(x => new TeacherCourseCreditInfo() {Assign = x.Credit, Remaining = 0}).FirstOrDefault();

                return Json(infos, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var info =
                    db.Teachers.Where(x => x.TeacherId == TeacherId)
                        .Select(
                            x =>
                                new TeacherCourseCreditInfo()
                                {
                                    Assign = x.Credit,
                                    Remaining = x.CourseTeachers.Sum(y => y.Course.Credit)
                                }).FirstOrDefault();
                return Json(info, JsonRequestBehavior.AllowGet);
            }
        }
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
                             join cT in db.CourseTeachers on c equals cT.Course into cTs
                             from cT in cTs.DefaultIfEmpty()
                             where c.DepartmentId == DepartmentId
                             select new DepartmentCourseSemester()
                             {
                                 Code = c.Code,
                                 Name = c.Name,
                                 Semester = c.Semester.Name,
                                 TeacherName = cT.Teacher.Name ?? "not assign"
                             };
            return Json(course, JsonRequestBehavior.AllowGet);
        }
    }
}