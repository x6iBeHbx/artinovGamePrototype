using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;

namespace GamePrototypeClasses.game.character
{
    public class Character : MainOptionsEntity
    {
        public CharacterWarehouse CharacterWarehouse { get; set; }
        public CharacterEquipment CharacterEquipment { get; set; }
        public CharacterTypeEnum CharacterType { get; set; }
    }
}
