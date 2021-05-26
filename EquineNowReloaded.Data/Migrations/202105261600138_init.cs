namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VetCheck", "HorseId", "dbo.Horse");
            DropIndex("dbo.VetCheck", new[] { "HorseId" });
            AlterColumn("dbo.VetCheck", "HorseId", c => c.Int());
            CreateIndex("dbo.VetCheck", "HorseId");
            AddForeignKey("dbo.VetCheck", "HorseId", "dbo.Horse", "HorseId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VetCheck", "HorseId", "dbo.Horse");
            DropIndex("dbo.VetCheck", new[] { "HorseId" });
            AlterColumn("dbo.VetCheck", "HorseId", c => c.Int(nullable: false));
            CreateIndex("dbo.VetCheck", "HorseId");
            AddForeignKey("dbo.VetCheck", "HorseId", "dbo.Horse", "HorseId", cascadeDelete: true);
        }
    }
}
