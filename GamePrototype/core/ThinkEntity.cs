using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeClasses.core
{
    public class ThinkEntity : MainOptionsEntity
    {
        public ThinksTypeEnum ThinksType { get; set; }
        public SpecialThinkBonus SpecialThinkBonus {get; set; }
        public int Price { get; set; }
    }
}
