namespace UniversityMgtSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tea : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teachers", "Credit", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "Credit", c => c.Int(nullable: false));
        }
    }
}
