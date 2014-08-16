using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class CourseTeacher
    {
        public int CourseTeacherId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int CourseId { get; set; }
        public virtual Department Department { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
  

    }
}