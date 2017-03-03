﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeClasses.core
{
    public class ThingEntity : MainOptionsEntity
    {
        [Required]
        public ThinksTypeEnum ThinksType { get; set; }
        [Required]
        public SpecialThingBonus SpecialThingBonus {get; set; }
        [Required]
        public int Price { get; set; }
    }
}
