using System.Collections.Generic;
using UniversityMgtSystem.Models;

namespace UniversityMgtSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityMgtSystem.Models.ProjectDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityMgtSystem.Models.ProjectDB context)
        {
            //var Departments = new List<Department>
            //{
            //    new Department { Name = "IPE",   Code = "IPE123"
            //       },
            //    new Department { Name = "Civil",   Code = "Civil123"
            //       },
               
            //};
            //Departments.ForEach(s => context.Departments.AddOrUpdate(s));
            //context.SaveChanges();

            //var Semesters = new List<Semester>
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
            //Semesters.ForEach(s => context.Semesters.AddOrUpdate(s));
            //context.SaveChanges();

            //var Designations = new List<Designation>
            //{
            //    new Designation { Name = " Assistant Professor"},

            //     new Designation { Name = "Associate Professor"},

            //     new Designation { Name = "Professor"},

            //     new Designation { Name = "Lecturer"},
                

            // };
            //Designations.ForEach(s => context.Designations.AddOrUpdate(s));
            //context.SaveChanges();


        }
    }
}
