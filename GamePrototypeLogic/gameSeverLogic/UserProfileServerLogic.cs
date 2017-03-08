﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.user;
using GamePrototypeDB.gameRepositories;

namespace GamePrototypeLogic.gameSeverLogic
{
    public class UserProfileServerLogic : BaseBusinessLogic<UserProfile>
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public IEnumerable<UserProfile> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public UserProfile GetUserByLogin(string login)
        {
            return GetAllUsers().FirstOrDefault(x => x.Login.Equals(login));
        }


    }
}
