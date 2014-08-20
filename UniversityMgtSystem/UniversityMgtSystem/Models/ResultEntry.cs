using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class ResultEntry
    {
        public int ResultEntryId { get; set; }
        [Required]
       
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required]
       
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }


    }
}