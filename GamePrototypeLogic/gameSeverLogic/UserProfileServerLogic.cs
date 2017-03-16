using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.user;
using GamePrototypeDB.gameRepositories;

namespace GamePrototypeLogic.gameSeverLogic
{
    public class UserProfileServerLogic : BaseBusinessLogic<UserProfile>
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public IQueryable<UserProfile> GetAllUsers()
        {
            var eee = _userRepository.GetAll();
            return _userRepository.GetAll();
        }

        public UserProfile GetUserByLogin(string login)
        {
            return _userRepository.GetUserByLogin(login);
        }

        public UserProfile GetUserByEmail(string email)
        {
            return GetAllUsers().FirstOrDefault(x => x.EMail.Equals(email));
        }

        public bool IsUserLoginDataValid(string login, string password)
        {
            UserProfile user = GetUserByLogin(login);
            return user != null && user.Login == login && user.Password == password;
        }
    }
}
