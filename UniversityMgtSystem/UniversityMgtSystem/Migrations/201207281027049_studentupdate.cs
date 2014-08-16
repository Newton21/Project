namespace UniversityMgtSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "ContactNo", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "ContactNo", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
