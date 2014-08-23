namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enroll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnrollCourses",
                c => new
                    {
                        EnrollCourseId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollCourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: false)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnrollCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.EnrollCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.EnrollCourses", new[] { "StudentId" });
            DropIndex("dbo.EnrollCourses", new[] { "CourseId" });
            DropTable("dbo.EnrollCourses");
        }
    }
}
