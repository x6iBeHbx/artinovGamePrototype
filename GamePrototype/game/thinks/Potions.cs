using System.Collections.Generic;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;

namespace GamePrototypeClasses.game.thinks
{
    public class Potions : ThinkEntity
    {
         public ICollection<CharacterWarehouse> CharacterWarehouses { get; set; } 
    }
}