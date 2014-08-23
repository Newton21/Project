using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Designation
    {
        public int DesignationId { get; set; }
        public string Name { set; get; }

        public virtual ICollection<Teacher> Teachers { set; get; } 

    }
}