using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototypeClasses.core
{
    public class MainOptionsEntity : LevelEntity
    {
        [Required]
        public int Health { set; get; }
        [Required]
        public int Mana { set; get; }
        [Required]
        public int Attack { set; get; }
        [Required]
        public int MagicAttack { set; get; }
        [Required]
        public int Defense { set; get; }
        [Required]
        public int MagicDefence { get; set; }
        [Required]
        public int Agility { set; get; }
        [Required]
        public int Intelligence { set; get; }
        [Required]
        public string ImageUrl { set; get; }
        [Required]
        public int Coins { get; set; }
    }
}
