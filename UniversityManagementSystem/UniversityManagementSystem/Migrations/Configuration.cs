using System.Collections.Generic;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityManagementSystem.Models.ProjectDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityManagementSystem.Models.ProjectDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //var semesters = new List<Semester>
            //{
            //    new Semester { Name = "Semester-01"},
            //    new Semester { Name = "Semester-02"},
            //    new Semester { Name = "Semester-03"},
            //    new Semester { Name = "Semester-04"},
            //    new Semester { Name = "Semester-05"},
            //    new Semester { Name = "Semester-06"},
            //    new Semester { Name = "Semester-07"},
            //    new Semester { Name = "Semester-08"}

            // };
            //semesters.ForEach(s => context.Semesters.AddOrUpdate(s));
            //context.SaveChanges();

            //var designations = new List<Designation>
            //{
            //    new Designation { Name = " Assistant Professor"},

            //     new Designation { Name = "Associate Professor"},

            //     new Designation { Name = "Professor"},

            //     new Designation { Name = "Lecturer"},


            // };
            //designations.ForEach(s => context.Designations.AddOrUpdate(s));
            //context.SaveChanges();

            //new List<GradeLetter>
            //{
            //    new GradeLetter {Grade = "A+"},
            //    new GradeLetter {Grade = "A"},
            //    new GradeLetter {Grade = "A-"},
            //    new GradeLetter {Grade = "B+"},
            //    new GradeLetter {Grade = "B"},
            //    new GradeLetter {Grade = "B-"},
            //    new GradeLetter {Grade = "C"},
            //    new GradeLetter {Grade = "D"},
            //    new GradeLetter {Grade = "F"}
            //}.ForEach(grades => context.GradeLetters.AddOrUpdate(grades));


            //new List<Room>
            //{
            //    new Room {RoomNo = "401"},
            //    new Room {RoomNo = "402"},
            //    new Room {RoomNo = "403"},
            //    new Room {RoomNo = "501"},
            //    new Room {RoomNo = "502"},
            //    new Room {RoomNo = "503"}
            //}.ForEach(rooms => context.Rooms.AddOrUpdate(rooms));

            //new List<Day>
            //{
            //    new Day {TimeDay = "Saturday"},
            //    new Day {TimeDay = "Sunday"},
            //    new Day {TimeDay = "Monday"},
            //    new Day {TimeDay = "Tuesday"},
            //    new Day {TimeDay = "Wednesday"},
            //    new Day {TimeDay = "Thursday"},
            //    new Day {TimeDay = "Friday"}
            //}.ForEach(day => context.Days.AddOrUpdate(day));

        }
    }
}
