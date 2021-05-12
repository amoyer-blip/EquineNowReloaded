namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditAuctionProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auction", "EmployeeId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auction", "EmployeeId");
        }
    }
}
