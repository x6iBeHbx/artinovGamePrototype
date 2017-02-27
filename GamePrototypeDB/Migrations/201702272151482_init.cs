namespace GamePrototypeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharacterEquipments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Hemlet = c.Int(nullable: false),
                        Armor = c.Int(nullable: false),
                        Boots = c.Int(nullable: false),
                        Gloves = c.Int(nullable: false),
                        Cloak = c.Int(nullable: false),
                        Necklace = c.Int(nullable: false),
                        Earrings = c.Int(nullable: false),
                        Rings1 = c.Int(nullable: false),
                        Rings2 = c.Int(nullable: false),
                        Rings3 = c.Int(nullable: false),
                        Weapon1 = c.Int(nullable: false),
                        Weapon2 = c.Int(nullable: false),
                        Scroll1 = c.Int(nullable: false),
                        Scroll2 = c.Int(nullable: false),
                        Scroll3 = c.Int(nullable: false),
                        Potion1 = c.Int(nullable: false),
                        Potion2 = c.Int(nullable: false),
                        Potion3 = c.Int(nullable: false),
                        Potion4 = c.Int(nullable: false),
                        Potion5 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CharacterWarehouses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Potions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThinksType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        SpecialThinkBonus_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThinkBonus", t => t.SpecialThinkBonus_Id)
                .Index(t => t.SpecialThinkBonus_Id);
            
            CreateTable(
                "dbo.SpecialThinkBonus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SpecialThinkBonusType = c.Int(nullable: false),
                        SpecialThinkBonusTimeType = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scrolls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThinksType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        SpecialThinkBonus_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThinkBonus", t => t.SpecialThinkBonus_Id)
                .Index(t => t.SpecialThinkBonus_Id);
            
            CreateTable(
                "dbo.Thinks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ThinksType = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Mana = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        MagicAttack = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                        MagicDefence = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        SpecialThinkBonus_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecialThinkBonus", t => t.SpecialThinkBonus_Id)
                .Index(t => t.SpecialThinkBonus_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LastName = c.String(),
                        EMail = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        UserSex = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        UserCharacter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Characters", t => t.UserCharacter_Id)
                .Index(t => t.UserCharacter_Id);
            
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
                        ImageUrl = c.String(),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        CharacterEquipment_Id = c.Guid(),
                        CharacterWarehouse_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CharacterEquipments", t => t.CharacterEquipment_Id)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id)
                .Index(t => t.CharacterEquipment_Id)
                .Index(t => t.CharacterWarehouse_Id);
            
            CreateTable(
                "dbo.PotionsCharacterWarehouses",
                c => new
                    {
                        Potions_Id = c.Guid(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Potions_Id, t.CharacterWarehouse_Id })
                .ForeignKey("dbo.Potions", t => t.Potions_Id, cascadeDelete: true)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .Index(t => t.Potions_Id)
                .Index(t => t.CharacterWarehouse_Id);
            
            CreateTable(
                "dbo.ScrollsCharacterWarehouses",
                c => new
                    {
                        Scrolls_Id = c.Guid(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Scrolls_Id, t.CharacterWarehouse_Id })
                .ForeignKey("dbo.Scrolls", t => t.Scrolls_Id, cascadeDelete: true)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .Index(t => t.Scrolls_Id)
                .Index(t => t.CharacterWarehouse_Id);
            
            CreateTable(
                "dbo.ThinksCharacterWarehouses",
                c => new
                    {
                        Thinks_Id = c.Guid(nullable: false),
                        CharacterWarehouse_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Thinks_Id, t.CharacterWarehouse_Id })
                .ForeignKey("dbo.Thinks", t => t.Thinks_Id, cascadeDelete: true)
                .ForeignKey("dbo.CharacterWarehouses", t => t.CharacterWarehouse_Id, cascadeDelete: true)
                .Index(t => t.Thinks_Id)
                .Index(t => t.CharacterWarehouse_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "UserCharacter_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.Characters", "CharacterEquipment_Id", "dbo.CharacterEquipments");
            DropForeignKey("dbo.Thinks", "SpecialThinkBonus_Id", "dbo.SpecialThinkBonus");
            DropForeignKey("dbo.ThinksCharacterWarehouses", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.ThinksCharacterWarehouses", "Thinks_Id", "dbo.Thinks");
            DropForeignKey("dbo.Scrolls", "SpecialThinkBonus_Id", "dbo.SpecialThinkBonus");
            DropForeignKey("dbo.ScrollsCharacterWarehouses", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.ScrollsCharacterWarehouses", "Scrolls_Id", "dbo.Scrolls");
            DropForeignKey("dbo.Potions", "SpecialThinkBonus_Id", "dbo.SpecialThinkBonus");
            DropForeignKey("dbo.PotionsCharacterWarehouses", "CharacterWarehouse_Id", "dbo.CharacterWarehouses");
            DropForeignKey("dbo.PotionsCharacterWarehouses", "Potions_Id", "dbo.Potions");
            DropIndex("dbo.ThinksCharacterWarehouses", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.ThinksCharacterWarehouses", new[] { "Thinks_Id" });
            DropIndex("dbo.ScrollsCharacterWarehouses", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.ScrollsCharacterWarehouses", new[] { "Scrolls_Id" });
            DropIndex("dbo.PotionsCharacterWarehouses", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.PotionsCharacterWarehouses", new[] { "Potions_Id" });
            DropIndex("dbo.Characters", new[] { "CharacterWarehouse_Id" });
            DropIndex("dbo.Characters", new[] { "CharacterEquipment_Id" });
            DropIndex("dbo.UserProfiles", new[] { "UserCharacter_Id" });
            DropIndex("dbo.Thinks", new[] { "SpecialThinkBonus_Id" });
            DropIndex("dbo.Scrolls", new[] { "SpecialThinkBonus_Id" });
            DropIndex("dbo.Potions", new[] { "SpecialThinkBonus_Id" });
            DropTable("dbo.ThinksCharacterWarehouses");
            DropTable("dbo.ScrollsCharacterWarehouses");
            DropTable("dbo.PotionsCharacterWarehouses");
            DropTable("dbo.Characters");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Thinks");
            DropTable("dbo.Scrolls");
            DropTable("dbo.SpecialThinkBonus");
            DropTable("dbo.Potions");
            DropTable("dbo.CharacterWarehouses");
            DropTable("dbo.CharacterEquipments");
        }
    }
}
