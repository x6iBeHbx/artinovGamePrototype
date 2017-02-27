using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.game.character;
using GamePrototype.game.thinks;
using GamePrototype.user;

namespace GamePrototypeDB
{
    class GameDBContext : DbContext 
    {
        public GameDBContext() : base("DBConnection")
        {
            
        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<CharacterEquipment> CharacterEquipment { get; set; }
        public DbSet<CharacterWarehouse> CharacterWarehouse { get; set; }
        public DbSet<Thinks> Thinks { get; set; }
        public DbSet<Scrolls> Scrolls { get; set; }
        public DbSet<Potions> Potions { get; set; }
        public DbSet<SpecialThinkBonus> SpecialThinkBonus { get; set; }
    }
}
