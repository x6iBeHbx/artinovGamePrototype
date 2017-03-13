using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.game.thinks;
using GamePrototypeDB.gameRepositories;

namespace GamePrototypeLogic.gameSeverLogic
{
    public class ThingsServerLogic : BaseBusinessLogic<Things>
    {
        private readonly ThingsRepository _thingRepository = new ThingsRepository();
        public IEnumerable<Things> GetAllThings()
        {
            return _thingRepository.GetAll();
        }
    }
}
