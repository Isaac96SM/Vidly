namespace WebApplicationVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rentalfeature : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
