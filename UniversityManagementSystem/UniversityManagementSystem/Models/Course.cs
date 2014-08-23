using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Required]

        [Remote("CodeExists", "Course", ErrorMessage = " Code Already Exists ")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]

        [Remote("NameExists", "Course", ErrorMessage = " Name Already Exists ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Credit")]
        public double Credit { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [Required(ErrorMessage = "Please select semester")]
        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }
        [DefaultValue(0)]
        public int CourseStatus { get; set; }
        public virtual ICollection<TeacherCourseAssign> TeacherCourseAssigns { get; set; }

        public virtual ICollection<EnrollCourse> EnrollCourses { set; get; }
        public virtual ICollection<ResultEntry> ResultEntries { set; get; }
        public virtual ICollection<AllocateClassRoom> AllocateClassRooms { get; set; }

    }

}