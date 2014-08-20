using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityMgtSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Enter Code")]
        [Remote ( "CodeExists","Course", ErrorMessage = " Code Already Exists ")]
        public string Code { get; set; }
          [Required(ErrorMessage = "Enter name")]
          [Remote("NameExists", "Course", ErrorMessage = " Name Already Exists ")]
        public string Name { get; set; }
         
        public string Description { get; set; }
          [Required(ErrorMessage = "Enter Credit")]
        public Double Credit { get; set; }
          [Required(ErrorMessage = "Enter Department Name ")]
          
        public int DepartmentId { get; set; }
          [Required(ErrorMessage = "Enter Semester Name")]
        public int SemesterId { get; set; }
        public virtual Department Department { set; get; }
        public virtual Semester Semester { set; get; }

        public virtual ICollection<CourseTeacher> CourseTeachers { set; get; }
        public virtual ICollection<EnrollCourse> EnrollCourses { set; get; }
        public virtual ICollection<ResultEntry> ResultEntries { set; get; } 


    }
}