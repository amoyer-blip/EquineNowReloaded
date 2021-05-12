namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auction",
                c => new
                    {
                        AuctionId = c.Int(nullable: false, identity: true),
                        AuctionName = c.String(nullable: false),
                        AuctionLocation = c.String(nullable: false),
                        TotalHorsesRescued = c.Int(nullable: false),
                        AuctionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuctionId);
            
            AddColumn("dbo.Horse", "Auction_AuctionId", c => c.Int());
            CreateIndex("dbo.Horse", "Auction_AuctionId");
            AddForeignKey("dbo.Horse", "Auction_AuctionId", "dbo.Auction", "AuctionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Horse", "Auction_AuctionId", "dbo.Auction");
            DropIndex("dbo.Horse", new[] { "Auction_AuctionId" });
            DropColumn("dbo.Horse", "Auction_AuctionId");
            DropTable("dbo.Auction");
        }
    }
}
