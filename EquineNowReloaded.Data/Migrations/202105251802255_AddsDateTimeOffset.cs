namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddsDateTimeOffset : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auction", "AuctionDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auction", "AuctionDate", c => c.DateTime(nullable: false));
        }
    }
}
