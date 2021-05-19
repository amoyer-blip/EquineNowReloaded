namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VetCheck",
                c => new
                    {
                        VetCheckId = c.Int(nullable: false, identity: true),
                        HorseId = c.Int(),
                        EmployeeId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sex = c.String(nullable: false),
                        Breed = c.String(nullable: false),
                        TreatmentPlan = c.String(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.VetCheckId)
                .ForeignKey("dbo.Horse", t => t.HorseId)
                .Index(t => t.HorseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VetCheck", "HorseId", "dbo.Horse");
            DropIndex("dbo.VetCheck", new[] { "HorseId" });
            DropTable("dbo.VetCheck");
        }
    }
}
