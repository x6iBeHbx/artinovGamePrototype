using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.game.character;

namespace GamePrototype.game.thinks
{
    public class Scrolls : ThinkEntity
    {
        public ICollection<CharacterWarehouse> CharacterWarehouses { get; set; }
    }
}
