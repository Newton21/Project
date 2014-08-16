using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class Designation
    {
        public int  DesignationId { get; set; }
        public string Name { set; get; }

        public virtual ICollection<Teacher> Teachers { set; get; } 

    }
}