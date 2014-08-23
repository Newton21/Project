using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class ResultEntry
    {
        public int ResultEntryId { get; set; }
        [Required(ErrorMessage = "Select Reg No")]
       
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Required(ErrorMessage = "Select a course")]
        
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required(ErrorMessage = "Select Grade")]
       
        public int GradeLetterId { get; set; }
        public virtual GradeLetter GradeLetter { get; set; }
    }
}