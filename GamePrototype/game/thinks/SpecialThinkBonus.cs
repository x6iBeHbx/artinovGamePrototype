using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.enums;

namespace GamePrototype.game.thinks
{
    public class SpecialThinkBonus : ValueEntity
    {
        public SpecialThinkBonusEnum SpecialThinkBonusType { get; set; }
        public SpecialThinkBonusTimeType SpecialThinkBonusTimeType { get; set; }
    }
}
