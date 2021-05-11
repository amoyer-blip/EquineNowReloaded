namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditHorse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horse", "HorseName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Horse", "HorseName");
        }
    }
}
