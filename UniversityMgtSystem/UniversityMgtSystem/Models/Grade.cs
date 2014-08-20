using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeLetter { get; set; }
        public virtual ICollection<ResultEntry> ResultEntries { set; get; } 
    }
}