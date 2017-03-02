using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeClasses.game.character
{
    public class CharacterWarehouse : ValueEntity
    {
        public ICollection<Potions> Potionses { get; set; } 
        public ICollection<Scrolls> Scrollses { get; set; } 
        public ICollection<Things> WarehouseThinkses { get; set; }
    }
}
