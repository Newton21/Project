using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityMgtSystem.Models
{
    public class Teacher
    {
        public int  TeacherId { get; set; }

        [Required (ErrorMessage = " enter name")]
        public string Name { get; set; }
         [Required(ErrorMessage = " enter Address")]

        public string Address { get; set; }
        [Required (ErrorMessage = " enter email")]
        [EmailAddress]
        [Remote ( "emailExists", "Teacher" , ErrorMessage = "  Email Address Exists")]
        public string Email { get; set; }
         [Required(ErrorMessage = " enter contact no")]
        public string ContactNo { get; set; }
         [Required(ErrorMessage = " enter credit")]
        public double Credit { get; set; }

         [Required(ErrorMessage = " enter designation")]

        public int DesignationId { get; set; }

         [Required(ErrorMessage = " enter department")]
        public int DepartmentId { get; set; }
        public virtual Designation Designation { set; get; }
        public virtual Department Department { set; get; }
        public virtual ICollection<CourseTeacher> CourseTeachers { set; get; } 
    }
}