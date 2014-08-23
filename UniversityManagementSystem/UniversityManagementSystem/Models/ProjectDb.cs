using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class ProjectDb:DbContext
    {
        public DbSet<Department> Departments { set; get; }

        public DbSet<Course> Courses { set; get; }
        public DbSet<Semester> Semesters { set; get; }

        public DbSet<Designation> Designations { set; get; }

        public DbSet<Teacher> Teachers { set; get; }
        public DbSet<TeacherCourseAssign> TeacherCourseAssigns { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<EnrollCourse> EnrollCourses { get; set; }

        public DbSet<ResultEntry> ResultEntries { get; set; }

        public DbSet<GradeLetter> GradeLetters { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }


    }
}