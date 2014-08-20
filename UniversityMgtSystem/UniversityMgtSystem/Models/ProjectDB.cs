using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityMgtSystem.Models
{
    public class ProjectDb:DbContext

    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Semester> Semesters { set; get; }

        public DbSet<Designation> Designations { set; get; }

        public DbSet<Teacher> Teachers { set; get; }

        public DbSet<Student> Students { set; get; }

        public DbSet<CourseTeacher> CourseTeachers { set; get; }
        public DbSet<EnrollCourse> EnrollCourses { set; get; }
        public DbSet<ResultEntry> ResultEntries { set; get; }
        public DbSet<Grade> Grades { set; get; } 
    }
}