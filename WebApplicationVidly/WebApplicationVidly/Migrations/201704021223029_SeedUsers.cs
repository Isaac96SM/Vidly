namespace WebApplicationVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b2b43fa0-5bf5-4966-8b09-528ba04984a7', N'admin@vidly.com', 0, N'AB5hjnEPSZFuc17rVQvWukJ2B2cOK/CuOaVZWCQdgGDQRIrkRnAMqSlTuUd7hB5+2w==', N'cec0c671-13a0-4476-8444-43020448c044', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ed8c069f-f045-4dc8-83c1-f1b77e8a8b9b', N'guest@vidly.com', 0, N'AMkK3VonXnghbr97FyXx0NvqQGVp67ojvvuJQ2p7Y1ZOFiFdZTsC/6YLE1/lNcMdCQ==', N'20487701-9615-45c5-90ce-798af42f6857', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'38e8abb8-eec7-4fb8-8465-b3654174c780', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b2b43fa0-5bf5-4966-8b09-528ba04984a7', N'38e8abb8-eec7-4fb8-8465-b3654174c780')
");
        }
        
        public override void Down()
        {
        }
    }
}
