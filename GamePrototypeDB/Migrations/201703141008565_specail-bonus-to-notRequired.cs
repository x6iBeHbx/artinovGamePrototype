namespace GamePrototypeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class specailbonustonotRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Things", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.Potions", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.Scrolls", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropIndex("dbo.Things", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Potions", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Scrolls", new[] { "SpecialThingBonus_Id" });
            AlterColumn("dbo.Things", "SpecialThingBonus_Id", c => c.Guid());
            AlterColumn("dbo.Potions", "SpecialThingBonus_Id", c => c.Guid());
            AlterColumn("dbo.Scrolls", "SpecialThingBonus_Id", c => c.Guid());
            CreateIndex("dbo.Things", "SpecialThingBonus_Id");
            CreateIndex("dbo.Potions", "SpecialThingBonus_Id");
            CreateIndex("dbo.Scrolls", "SpecialThingBonus_Id");
            AddForeignKey("dbo.Things", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id");
            AddForeignKey("dbo.Potions", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id");
            AddForeignKey("dbo.Scrolls", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scrolls", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.Potions", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.Things", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropIndex("dbo.Scrolls", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Potions", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Things", new[] { "SpecialThingBonus_Id" });
            AlterColumn("dbo.Scrolls", "SpecialThingBonus_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Potions", "SpecialThingBonus_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Things", "SpecialThingBonus_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Scrolls", "SpecialThingBonus_Id");
            CreateIndex("dbo.Potions", "SpecialThingBonus_Id");
            CreateIndex("dbo.Things", "SpecialThingBonus_Id");
            AddForeignKey("dbo.Scrolls", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Potions", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Things", "SpecialThingBonus_Id", "dbo.SpecialThingBonus", "Id", cascadeDelete: true);
        }
    }
}
