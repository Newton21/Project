using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class TeacherCourseAssign
    {
        public int TeacherCourseAssignId { get; set; }

        [Required(ErrorMessage = " Please Select Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = " Please Select Teacher")]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        [Required(ErrorMessage = "Please Select Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}