﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.game.thinks;
using GamePrototypeClasses.user;

namespace GamePrototypeDB
{
    public class GameDBContext : DbContext 
    {
        public GameDBContext() : base("DBConnection")
        {

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<CharacterEquipment> CharacterEquipment { get; set; }
        public DbSet<CharacterWarehouse> CharacterWarehouse { get; set; }
        public DbSet<Things> Things { get; set; }
        public DbSet<Scrolls> Scrolls { get; set; }
        public DbSet<Potions> Potions { get; set; }
        public DbSet<CharacterThings> CharacterThings { get; set; }
        public DbSet<CharacterSrolls> CharacterSrolls { get; set; }
        public DbSet<CharacterPotions> CharacterPotions { get; set; }
        public DbSet<SpecialThingBonus> SpecialThinkBonus { get; set; }
    }
}
