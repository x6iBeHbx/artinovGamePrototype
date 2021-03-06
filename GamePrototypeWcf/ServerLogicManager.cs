﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeLogic;
using GamePrototypeLogic.gameSeverLogic;

namespace GamePrototypeWcf
{
    public class ServerLogicManager
    {

        public ServerLogicManager()
        {
            UserProfileServerLogic = new UserProfileServerLogic();
            CharacterBaseBusinessLogic = new CharacterServerLogic();
            ThingsServerLogic = new ThingsServerLogic();
            CharacterThingsServerLogic = new CharacterThingsServerLogic();
            WareBaseBusinessLogic = new BaseBusinessLogic<CharacterWarehouse>();
        }

        public UserProfileServerLogic UserProfileServerLogic { get; protected set; }
        public CharacterServerLogic CharacterBaseBusinessLogic { get; protected set; }
        public BaseBusinessLogic<CharacterWarehouse> WareBaseBusinessLogic { get; protected set; }
        public ThingsServerLogic ThingsServerLogic { get; protected set; }
        public CharacterThingsServerLogic CharacterThingsServerLogic { get; set; }
    }
}