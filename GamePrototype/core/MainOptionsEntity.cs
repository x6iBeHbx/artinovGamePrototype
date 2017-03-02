using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    public class MainOptionsEntity : LevelEntity
    {
        public int Health { set; get; }
        public int Mana { set; get; }
        public int Attack { set; get; }
        public int MagicAttack { set; get; }
        public int Defense { set; get; }
        public int MagicDefence { get; set; }
        public int Agility { set; get; }
        public int Intelligence { set; get; }
        public string ImageUrl { set; get; }
    }
}
