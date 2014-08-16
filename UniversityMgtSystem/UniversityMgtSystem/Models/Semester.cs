using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { set; get; } 
    }
}