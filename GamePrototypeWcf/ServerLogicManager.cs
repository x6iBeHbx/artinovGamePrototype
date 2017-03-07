using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamePrototypeLogic.gameSeverLogic;

namespace GamePrototypeWcf
{
    public class ServerLogicManager
    {

        public ServerLogicManager()
        {
            UserProfileServerLogic = new UserProfileServerLogic();
        }

        public UserProfileServerLogic UserProfileServerLogic { get; protected set; }
    }
}