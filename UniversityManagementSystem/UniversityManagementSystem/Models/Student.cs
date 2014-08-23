﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string RegNo { get; set; }
        [Required]
       
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string ContactNo { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Please select department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<EnrollCourse> EnrollCourses { set; get; }

        public virtual ICollection<ResultEntry> ResultEntries { set; get; } 



    }
}