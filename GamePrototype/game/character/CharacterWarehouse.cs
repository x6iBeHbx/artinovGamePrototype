using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.game.thinks;

namespace GamePrototype.game.character
{
    public class CharacterWarehouse : ValueEntity
    {
        public ICollection<Potions> Potionses { get; set; } 
        public ICollection<Scrolls> Scrollses { get; set; } 
        public ICollection<Thinks> WarehouseThinkses { get; set; }
    }
}
