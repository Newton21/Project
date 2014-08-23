using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "  Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Please enter Address")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress]
        [Remote("emailExists", "Teacher", ErrorMessage = "  Email Address Exists")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter contact no")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Please enter credit")]
        public double Credit { get; set; }


        [Required(ErrorMessage = "Please enter designation")]

        public int DesignationId { get; set; }

        [Required(ErrorMessage = "Please enter department")]
        public int DepartmentId { get; set; }
        public virtual Designation Designation { set; get; }
        public virtual Department Department { set; get; }
        public virtual ICollection<TeacherCourseAssign> CourseTeachers { set; get; } 
    }
}