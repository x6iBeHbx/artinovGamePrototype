using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeDB.gameRepositories;

namespace GamePrototypeLogic.gameSeverLogic
{
    class ThingsServerLogic : BaseBusinessLogic<ThingEntity>
    {
        private readonly ThingsRepository _characterRepository = new ThingsRepository();
        public IEnumerable<ThingEntity> GetAllThings()
        {
            return _characterRepository.GetAll();
        }
    }
}
