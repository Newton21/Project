namespace UniversityMgtSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacherupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teachers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String());
            AlterColumn("dbo.Teachers", "Email", c => c.String());
            AlterColumn("dbo.Teachers", "Address", c => c.String());
            AlterColumn("dbo.Teachers", "Name", c => c.String());
        }
    }
}
