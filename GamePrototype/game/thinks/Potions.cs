using System.Collections.Generic;
using GamePrototype.core;
using GamePrototype.game.character;

namespace GamePrototype.game.thinks
{
    public class Potions : ThinkEntity
    {
         public ICollection<CharacterWarehouse> CharacterWarehouses { get; set; } 
    }
}