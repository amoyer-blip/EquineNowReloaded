namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuctionIdAsFK : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Horse", name: "Auction_AuctionId", newName: "AuctionId");
            RenameIndex(table: "dbo.Horse", name: "IX_Auction_AuctionId", newName: "IX_AuctionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Horse", name: "IX_AuctionId", newName: "IX_Auction_AuctionId");
            RenameColumn(table: "dbo.Horse", name: "AuctionId", newName: "Auction_AuctionId");
        }
    }
}
