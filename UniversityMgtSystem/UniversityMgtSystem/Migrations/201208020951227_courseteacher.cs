namespace UniversityMgtSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courseteacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseTeachers",
                c => new
                    {
                        CourseTeacherId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseTeacherId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: false)
                .Index(t => t.CourseId)
                .Index(t => t.DepartmentId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.CourseTeachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.CourseTeachers", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseTeachers", new[] { "TeacherId" });
            DropIndex("dbo.CourseTeachers", new[] { "DepartmentId" });
            DropIndex("dbo.CourseTeachers", new[] { "CourseId" });
            DropTable("dbo.CourseTeachers");
        }
    }
}
