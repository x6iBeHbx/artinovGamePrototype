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
        public Things HemletId { get; set; }
        public Things ArmorId { get; set; }
        public Things BootsId { get; set; }
        public Things GlovesId { get; set; }
        public Things CloakId { get; set; }
        public Things NecklaceId { get; set; }
        public Things EarringsId { get; set; }
        public Things RingsId1 { get; set; }
        public Things RingsId2 { get; set; }
        public Things RingsId3 { get; set; }
        public Things WeaponId1 { get; set; }
        public Things WeaponId2 { get; set; }
        public Scrolls ScrollId1 { get; set; }
        public Scrolls ScrollId2 { get; set; }
        public Scrolls ScrollId3 { get; set; }
        public Potions PotionId1 { get; set; }
        public Potions PotionId2 { get; set; }
        public Potions PotionId3 { get; set; }
        public Potions PotionId4 { get; set; }
        public Potions PotionId5 { get; set; }
    }
}
