using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.enums;

namespace GamePrototype.game.character
{
    public class Character : MainOptionsEntity
    {
        public CharacterWarehouse CharacterWarehouse { get; set; }
        public CharacterEquipment CharacterEquipment { get; set; }
        public CharacterTypeEnum CharacterType { get; set; }
    }
}
