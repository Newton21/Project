using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class EnrollCourse
    {
        public int EnrollCourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required(ErrorMessage = " Please Select a course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required(ErrorMessage = "Please Enter Date")]
        public DateTime Date { get; set; }

    }
}