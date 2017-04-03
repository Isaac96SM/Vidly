namespace WebApplicationVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unknown2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "DrivingLicnse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicnse", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
