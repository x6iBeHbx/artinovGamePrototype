using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeClasses.game.character
{
    public class CharacterEquipment  : IdEntity
    {
        public Things Hemlet { get; set; }
        public Things Armor { get; set; }
        public Things Boots { get; set; }
        public Things Gloves { get; set; }
        public Things Cloak { get; set; }
        public Things Necklace { get; set; }
        public Things Earrings { get; set; }
        public Things Rings1 { get; set; }
        public Things Rings2 { get; set; }
        public Things Rings3 { get; set; }
        public Things Weapon1 { get; set; }
        public Things Weapon2 { get; set; }
        public Scrolls Scroll1 { get; set; }
        public Scrolls Scroll2 { get; set; }
        public Scrolls Scroll3 { get; set; }
        public Potions Potion1 { get; set; }
        public Potions Potion2 { get; set; }
        public Potions Potion3 { get; set; }
        public Potions Potion4 { get; set; }
        public Potions Potion5 { get; set; }
    }
}
