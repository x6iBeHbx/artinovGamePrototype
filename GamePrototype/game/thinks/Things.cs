using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;

namespace GamePrototypeClasses.game.thinks
{
    public class Thinks : ThinkEntity
    {
        public ICollection<CharacterWarehouse> CharacterWarehouses { get; set; }
    }
}
