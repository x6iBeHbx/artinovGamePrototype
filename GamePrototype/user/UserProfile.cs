using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character;

namespace GamePrototypeClasses.user
{
    public class UserProfile : NameEntity
    {

        [Required]
        public string LastName { set; get; }
        [Required]
        public string EMail { set; get; }
        [Required]
        public int Age { set; get; }
        public string PhoneNumber { set; get; }
        [Required]
        public UserSexEnum UserSex { set; get; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public Character UserCharacter { set; get; }
    }
}
