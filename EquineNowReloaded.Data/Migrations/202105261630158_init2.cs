namespace EquineNowReloaded.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horse", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Horse", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Horse", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Horse", "Sex", c => c.String(nullable: false));
            AddColumn("dbo.Horse", "Breed", c => c.String(nullable: false));
            AddColumn("dbo.VetCheck", "ImmediateMedical", c => c.Boolean(nullable: false));
            AddColumn("dbo.VetCheck", "IntakeNotes", c => c.String(nullable: false));
            AddColumn("dbo.VetCheck", "Injury", c => c.String(nullable: false));
            DropColumn("dbo.Horse", "ImmediateMedical");
            DropColumn("dbo.Horse", "IntakeNotes");
            DropColumn("dbo.Horse", "Injury");
            DropColumn("dbo.VetCheck", "Name");
            DropColumn("dbo.VetCheck", "Age");
            DropColumn("dbo.VetCheck", "Height");
            DropColumn("dbo.VetCheck", "Weight");
            DropColumn("dbo.VetCheck", "Sex");
            DropColumn("dbo.VetCheck", "Breed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VetCheck", "Breed", c => c.String(nullable: false));
            AddColumn("dbo.VetCheck", "Sex", c => c.String(nullable: false));
            AddColumn("dbo.VetCheck", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VetCheck", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VetCheck", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.VetCheck", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Horse", "Injury", c => c.String(nullable: false));
            AddColumn("dbo.Horse", "IntakeNotes", c => c.String(nullable: false));
            AddColumn("dbo.Horse", "ImmediateMedical", c => c.Boolean(nullable: false));
            DropColumn("dbo.VetCheck", "Injury");
            DropColumn("dbo.VetCheck", "IntakeNotes");
            DropColumn("dbo.VetCheck", "ImmediateMedical");
            DropColumn("dbo.Horse", "Breed");
            DropColumn("dbo.Horse", "Sex");
            DropColumn("dbo.Horse", "Weight");
            DropColumn("dbo.Horse", "Height");
            DropColumn("dbo.Horse", "Age");
        }
    }
}
