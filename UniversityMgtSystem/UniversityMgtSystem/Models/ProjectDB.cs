using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class ProjectDB:DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Semester> Semesters { set; get; }

        public DbSet<Designation> Designations { set; get; }

        public DbSet<Teacher> Teachers { set; get; }

        public DbSet<Student> Students { set; get; }

        public DbSet<CourseTeacher> CourseTeachers { set; get; } 
    }
}