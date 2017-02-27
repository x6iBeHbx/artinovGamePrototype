using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.enums;
using GamePrototype.game.thinks;

namespace GamePrototype.core
{
    public class ThinkEntity : MainOptionsEntity
    {
        public ThinksTypeEnum ThinksType { get; set; }
        public SpecialThinkBonus SpecialThinkBonus {get; set; }
        public int Price { get; set; }
    }
}
