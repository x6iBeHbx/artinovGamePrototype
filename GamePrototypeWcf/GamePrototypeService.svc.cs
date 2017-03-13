using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.user;
using GamePrototypeLogic;
using GamePrototypeLogic.gameSeverLogic;

namespace GamePrototypeWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GamePrototypeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GamePrototypeService.svc or GamePrototypeService.svc.cs at the Solution Explorer and start debugging.
    public class GamePrototypeService : IGamePrototypeService
    {
        private readonly ServerLogicManager _serverLogicManager = new ServerLogicManager();

        #region Setters
        public void SetUserProfile(UserProfile user)
        {
            _serverLogicManager.UserProfileServerLogic.AddEntity(user);
        }

        public void SetCharacter(Character character)
        {
            _serverLogicManager.CharacterBaseBusinessLogic.AddEntity(character);
        }

        public void SetNewThing(ThingEntity thing)
        {
            _serverLogicManager.ThingsServerLogic.;
        }

        #endregion

        #region Getters

        public UserProfile GetUserByLogin(string login)
        {
            return _serverLogicManager.UserProfileServerLogic.GetUserByLogin(login);
        }

        public UserProfile GetUserByEmail(string email)
        {
            return _serverLogicManager.UserProfileServerLogic.GetUserByEmail(email);
        }

        public bool IsUserLoginDataValid(string login, string pass)
        {
            return _serverLogicManager.UserProfileServerLogic.IsUserLoginDataValid(login, pass);
        }


        #endregion 
    }
}
