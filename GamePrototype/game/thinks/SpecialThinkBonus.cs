using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;

namespace GamePrototypeClasses.game.thinks
{
    public class SpecialThinkBonus : ValueEntity
    {
        public SpecialThinkBonusEnum SpecialThinkBonusType { get; set; }
        public SpecialThinkBonusTimeType SpecialThinkBonusTimeType { get; set; }
    }
}
