using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;

namespace GamePrototypeClasses.game.thinks
{
    public class SpecialThingBonus : ValueEntity
    {
        [MaxLength(400)]
        public string Description { get; set; }
        [Required]
        public SpecialThinkBonusEnum SpecialThinkBonusType { get; set; }
        [Required]
        public SpecialThingBonusTimeEnum SpecialThingBonusTimeEnum { get; set; }
    }
}
