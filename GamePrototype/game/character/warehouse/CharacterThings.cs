﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeClasses.game.character.warehouse
{
    public class CharacterThings : ValueEntity
    {
        [Required]
        public Guid ThingId { get; set; }
        [Required]
        public Guid WarehouseId { get; set; }
    }
}
