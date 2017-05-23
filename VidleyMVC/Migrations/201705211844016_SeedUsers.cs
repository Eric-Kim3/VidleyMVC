namespace VidleyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b18ffffd-26e0-4d46-b2d1-d22484c279cd', N'admin@vidley.com', 0, N'AKI5+MbftxEM2X/nw77ddpexBkK6rlYQ4RNr2HCdVmA5otRJ7NnAoTXo1hqYBgi2bQ==', N'daac1c6d-419d-46ab-a1b5-936fc9eaa00d', NULL, 0, 0, NULL, 1, 0, N'admin@vidley.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb59a7d8-a037-462b-a94b-9964a4fb3f61', N'guest@vidley.com', 0, N'ACo+TLcHUz9NP2pMTsOJv9+EVCeeSgsQS0/YV+AySabbq9BehVxQobzUvvA0luj2Iw==', N'e0006efe-653f-454f-b2c6-74acab9dc2b2', NULL, 0, 0, NULL, 1, 0, N'guest@vidley.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f592ba0d-29fc-4e89-81e4-e79fd37b02ac', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b18ffffd-26e0-4d46-b2d1-d22484c279cd', N'f592ba0d-29fc-4e89-81e4-e79fd37b02ac')

");
        }
        
        public override void Down()
        {
        }
    }
}
