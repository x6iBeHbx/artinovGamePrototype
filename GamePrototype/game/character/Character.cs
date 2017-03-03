using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character.warehouse;

namespace GamePrototypeClasses.game.character
{
    public class Character : MainOptionsEntity
    {
        [Required]
        public CharacterWarehouse CharacterWarehouse { get; set; }
        [Required]
        public CharacterEquipment CharacterEquipment { get; set; }
        [Required]
        public CharacterTypeEnum CharacterType { get; set; }
    }
}
