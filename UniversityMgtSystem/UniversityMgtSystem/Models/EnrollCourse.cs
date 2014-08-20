using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class EnrollCourse
    {
        public int EnrollCourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required]
        public int CourseId { set; get; }
        public virtual Course Course  { get; set; }
        [Required]
        public DateTime Date { set; get; }

    }
}