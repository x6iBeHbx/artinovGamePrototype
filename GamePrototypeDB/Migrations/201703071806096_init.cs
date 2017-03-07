namespace GamePrototypeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CharacterType = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 300),
                        CharacterEquipment_Id = c.Guid(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterEquipments", t => t.CharacterEquipment_Id, cascadeDelete: true)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .Index(t => t.CharacterEquipment_Id)
                .Index(t => t.CharacterWarehouse_Id);
            
            CreateTable(
                "dbo.CharacterEquipments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Armor_Id = c.Guid(),
                        Boots_Id = c.Guid(),
                        Cloak_Id = c.Guid(),
                        Earrings_Id = c.Guid(),
                        Gloves_Id = c.Guid(),
                        Hemlet_Id = c.Guid(),
                        Necklace_Id = c.Guid(),
                        Potion1_Id = c.Guid(),
                        Potion2_Id = c.Guid(),
                        Potion3_Id = c.Guid(),
                        Potion4_Id = c.Guid(),
                        Potion5_Id = c.Guid(),
                        Rings1_Id = c.Guid(),
                        Rings2_Id = c.Guid(),
                        Rings3_Id = c.Guid(),
                        Scroll1_Id = c.Guid(),
                        Scroll2_Id = c.Guid(),
                        Scroll3_Id = c.Guid(),
                        Weapon1_Id = c.Guid(),
                        Weapon2_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Things", t => t.Armor_Id)
                .ForeignKey("dbo.Things", t => t.Boots_Id)
                .ForeignKey("dbo.Things", t => t.Cloak_Id)
                .ForeignKey("dbo.Things", t => t.Earrings_Id)
                .ForeignKey("dbo.Things", t => t.Gloves_Id)
                .ForeignKey("dbo.Things", t => t.Hemlet_Id)
                .ForeignKey("dbo.Things", t => t.Necklace_Id)
                .ForeignKey("dbo.Potions", t => t.Potion1_Id)
                .ForeignKey("dbo.Potions", t => t.Potion2_Id)
                .ForeignKey("dbo.Potions", t => t.Potion3_Id)
                .ForeignKey("dbo.Potions", t => t.Potion4_Id)
                .ForeignKey("dbo.Potions", t => t.Potion5_Id)
                .ForeignKey("dbo.Things", t => t.Rings1_Id)
                .ForeignKey("dbo.Things", t => t.Rings2_Id)
                .ForeignKey("dbo.Things", t => t.Rings3_Id)
                .ForeignKey("dbo.Scrolls", t => t.Scroll1_Id)
                .ForeignKey("dbo.Scrolls", t => t.Scroll2_Id)
                .ForeignKey("dbo.Scrolls", t => t.Scroll3_Id)
                .ForeignKey("dbo.Things", t => t.Weapon1_Id)
                .ForeignKey("dbo.Things", t => t.Weapon2_Id)
                .Index(t => t.Armor_Id)
                .Index(t => t.Boots_Id)
                .Index(t => t.Cloak_Id)
                .Index(t => t.Earrings_Id)
                .Index(t => t.Gloves_Id)
                .Index(t => t.Hemlet_Id)
                .Index(t => t.Necklace_Id)
                .Index(t => t.Potion1_Id)
                .Index(t => t.Potion2_Id)
                .Index(t => t.Potion3_Id)
                .Index(t => t.Potion4_Id)
                .Index(t => t.Potion5_Id)
                .Index(t => t.Rings1_Id)
                .Index(t => t.Rings2_Id)
                .Index(t => t.Rings3_Id)
                .Index(t => t.Scroll1_Id)
                .Index(t => t.Scroll2_Id)
                .Index(t => t.Scroll3_Id)
                .Index(t => t.Weapon1_Id)
                .Index(t => t.Weapon2_Id);
            
            CreateTable(
                "dbo.Things",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThingsType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 300),
                        SpecialThingBonus_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThingBonus", t => t.SpecialThingBonus_Id, cascadeDelete: true)
                .Index(t => t.SpecialThingBonus_Id);
            
            CreateTable(
                "dbo.SpecialThingBonus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Description = c.String(maxLength: 400),
                        SpecialThinkBonusType = c.Int(nullable: false),
                        SpecialThingBonusTimeEnum = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Potions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThingsType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 300),
                        SpecialThingBonus_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThingBonus", t => t.SpecialThingBonus_Id, cascadeDelete: true)
                .Index(t => t.SpecialThingBonus_Id);
            
            CreateTable(
                "dbo.Scrolls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThingsType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 300),
                        SpecialThingBonus_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThingBonus", t => t.SpecialThingBonus_Id, cascadeDelete: true)
                .Index(t => t.SpecialThingBonus_Id);
            
            CreateTable(
                "dbo.CharacterWarehouses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CharacterPotions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                        Potion_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .ForeignKey("dbo.Potions", t => t.Potion_Id, cascadeDelete: true)
                .Index(t => t.CharacterWarehouse_Id)
                .Index(t => t.Potion_Id);
            
            CreateTable(
                "dbo.CharacterSrolls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                        Scroll_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .ForeignKey("dbo.Scrolls", t => t.Scroll_Id, cascadeDelete: true)
                .Index(t => t.CharacterWarehouse_Id)
                .Index(t => t.Scroll_Id);
            
            CreateTable(
                "dbo.CharacterThings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                        Thing_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .ForeignKey("dbo.Things", t => t.Thing_Id, cascadeDelete: true)
                .Index(t => t.CharacterWarehouse_Id)
                .Index(t => t.Thing_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LastName = c.String(nullable: false),
                        EMail = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        UserSex = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 300),
                        UserCharacter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Characters", t => t.UserCharacter_Id)
                .Index(t => t.UserCharacter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "UserCharacter_Id", "dbo.Characters");
            DropForeignKey("dbo.CharacterThings", "Thing_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterThings", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.CharacterSrolls", "Scroll_Id", "dbo.Scrolls");
            DropForeignKey("dbo.CharacterSrolls", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.CharacterPotions", "Potion_Id", "dbo.Potions");
            DropForeignKey("dbo.CharacterPotions", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.Characters", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.Characters", "CharacterEquipment_Id", "dbo.CharacterEquipments");
            DropForeignKey("dbo.CharacterEquipments", "Weapon2_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Weapon1_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Scroll3_Id", "dbo.Scrolls");
            DropForeignKey("dbo.CharacterEquipments", "Scroll2_Id", "dbo.Scrolls");
            DropForeignKey("dbo.CharacterEquipments", "Scroll1_Id", "dbo.Scrolls");
            DropForeignKey("dbo.Scrolls", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.CharacterEquipments", "Rings3_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Rings2_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Rings1_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Potion5_Id", "dbo.Potions");
            DropForeignKey("dbo.CharacterEquipments", "Potion4_Id", "dbo.Potions");
            DropForeignKey("dbo.CharacterEquipments", "Potion3_Id", "dbo.Potions");
            DropForeignKey("dbo.CharacterEquipments", "Potion2_Id", "dbo.Potions");
            DropForeignKey("dbo.CharacterEquipments", "Potion1_Id", "dbo.Potions");
            DropForeignKey("dbo.Potions", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropForeignKey("dbo.CharacterEquipments", "Necklace_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Hemlet_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Gloves_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Earrings_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Cloak_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Boots_Id", "dbo.Things");
            DropForeignKey("dbo.CharacterEquipments", "Armor_Id", "dbo.Things");
            DropForeignKey("dbo.Things", "SpecialThingBonus_Id", "dbo.SpecialThingBonus");
            DropIndex("dbo.UserProfiles", new[] { "UserCharacter_Id" });
            DropIndex("dbo.CharacterThings", new[] { "Thing_Id" });
            DropIndex("dbo.CharacterThings", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.CharacterSrolls", new[] { "Scroll_Id" });
            DropIndex("dbo.CharacterSrolls", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.CharacterPotions", new[] { "Potion_Id" });
            DropIndex("dbo.CharacterPotions", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.Scrolls", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Potions", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.Things", new[] { "SpecialThingBonus_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Weapon2_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Weapon1_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Scroll3_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Scroll2_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Scroll1_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Rings3_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Rings2_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Rings1_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Potion5_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Potion4_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Potion3_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Potion2_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Potion1_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Necklace_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Hemlet_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Gloves_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Earrings_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Cloak_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Boots_Id" });
            DropIndex("dbo.CharacterEquipments", new[] { "Armor_Id" });
            DropIndex("dbo.Characters", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.Characters", new[] { "CharacterEquipment_Id" });
            DropTable("dbo.UserProfiles");
            DropTable("dbo.CharacterThings");
            DropTable("dbo.CharacterSrolls");
            DropTable("dbo.CharacterPotions");
            DropTable("dbo.CharacterWarehouses");
            DropTable("dbo.Scrolls");
            DropTable("dbo.Potions");
            DropTable("dbo.SpecialThingBonus");
            DropTable("dbo.Things");
            DropTable("dbo.CharacterEquipments");
            DropTable("dbo.Characters");
        }
    }
}
