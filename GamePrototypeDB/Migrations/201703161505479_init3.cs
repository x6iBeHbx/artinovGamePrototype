namespace GamePrototypeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CharacterThings", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.CharacterThings", "Thing_Id", "dbo.Things");
            DropIndex("dbo.CharacterThings", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.CharacterThings", new[] { "Thing_Id" });
            AddColumn("dbo.CharacterThings", "ThingId", c => c.Guid(nullable: false));
            AddColumn("dbo.CharacterThings", "WarehouseId", c => c.Guid(nullable: false));
            DropColumn("dbo.CharacterThings", "CharacterWarehouse_Id");
            DropColumn("dbo.CharacterThings", "Thing_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CharacterThings", "Thing_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.CharacterThings", "CharacterWarehouse_Id", c => c.Guid(nullable: false));
            DropColumn("dbo.CharacterThings", "WarehouseId");
            DropColumn("dbo.CharacterThings", "ThingId");
            CreateIndex("dbo.CharacterThings", "Thing_Id");
            CreateIndex("dbo.CharacterThings", "CharacterWarehouse_Id");
            AddForeignKey("dbo.CharacterThings", "Thing_Id", "dbo.Things", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CharacterThings", "CharacterWarehouse_Id", "dbo.CharacterWarehouses", "Id", cascadeDelete: true);
        }
    }
}
