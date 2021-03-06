﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "please enter department Name")]

        [Remote("NameExists", "Department", ErrorMessage = "Name Already Exists")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter department Code")]

        [Remote("CodeExists", "Department", ErrorMessage = "Code Already Exists")]
        public string Code { get; set; }
        public virtual ICollection<Course> Courses { set; get; }

        public virtual ICollection<Teacher> Teachers { set; get; }

        public virtual ICollection<TeacherCourseAssign> TeacherCourseAssigns { set; get; }
        public virtual ICollection<Student> Students { set; get; }

        public virtual ICollection<AllocateClassRoom> AllocateClassRooms { get; set; }



    }
}