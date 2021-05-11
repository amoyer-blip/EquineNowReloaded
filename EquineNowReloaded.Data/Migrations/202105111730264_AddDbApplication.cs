namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDbApplication : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Horse", "AuctionName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Horse", "AuctionName", c => c.Int(nullable: false));
        }
    }
}
