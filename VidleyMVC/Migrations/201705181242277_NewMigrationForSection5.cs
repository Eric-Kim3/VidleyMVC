namespace VidleyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigrationForSection5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
    }
}
