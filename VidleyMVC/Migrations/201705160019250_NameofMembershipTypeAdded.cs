namespace VidleyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameofMembershipTypeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "NameOfMembershipType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "NameOfMembershipType");
        }
    }
}
