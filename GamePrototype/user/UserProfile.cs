using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototype.core;
using GamePrototype.enums;
using GamePrototype.game.character;

namespace GamePrototype.user
{
    public class UserProfile : NameEntity
    {
        public string LastName { set; get; }
        public string EMail { set; get; }
        public int Age { set; get; }
        public string PhoneNumber { set; get; }
        public UserSexEnum UserSex { set; get; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Character UserCharacter { set; get; }
    }
}
