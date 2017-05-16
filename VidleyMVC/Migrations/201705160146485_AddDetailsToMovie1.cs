namespace VidleyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDetailsToMovie1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
