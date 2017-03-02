using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;

namespace GamePrototypeClasses.game.thinks
{
    public class Scrolls : ThinkEntity
    {
        public ICollection<CharacterWarehouse> CharacterWarehouses { get; set; }
    }
}
