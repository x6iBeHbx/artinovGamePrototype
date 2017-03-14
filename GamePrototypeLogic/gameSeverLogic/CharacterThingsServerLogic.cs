using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeLogic.gameSeverLogic
{
    public class CharacterThingsServerLogic : BaseBusinessLogic<CharacterThings>
    {
        public IQueryable<CharacterThings> GetAllCharacterThings(Character character)
        {
            return GetAllEntity().Where(x => x.CharacterWarehouse.Id.Equals(character.CharacterWarehouse.Id));
        }

        public void SetThingToWarehouse(Things thing, CharacterWarehouse warehouse)
        {
            CharacterThings characterThing = new CharacterThings
            {
                Thing = thing,
                CharacterWarehouse = warehouse,
                Value = 1
            };

            AddEntity(characterThing);
        }
    }
}
