using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamePrototypeClasses.game.character;
using GamePrototypeLogic;
using GamePrototypeLogic.gameSeverLogic;

namespace GamePrototypeWcf
{
    public class ServerLogicManager
    {

        public ServerLogicManager()
        {
            UserProfileServerLogic = new UserProfileServerLogic();
            CharacterBaseBusinessLogic = new BaseBusinessLogic<Character>();
        }

        public UserProfileServerLogic UserProfileServerLogic { get; protected set; }
        public BaseBusinessLogic<Character> CharacterBaseBusinessLogic { get; protected set; }
    }
}