using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GamePrototypeClasses.user;
using GamePrototypeLogic;

namespace GamePrototypeWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GamePrototypeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GamePrototypeService.svc or GamePrototypeService.svc.cs at the Solution Explorer and start debugging.
    public class GamePrototypeService : IGamePrototypeService
    {
        private readonly ServerLogicManager _serverLogicManager = new ServerLogicManager();
        public void SetUserProfile(UserProfile user)
        {
            _serverLogicManager.UserProfileServerLogic.AddEntity(user);
        }
    }
}
