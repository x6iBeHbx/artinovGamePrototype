using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;

namespace GamePrototypeLogic.gameSeverLogic
{
    public class CharacterThingsServerLogic : BaseBusinessLogic<CharacterThings>
    {
        public IEnumerable<CharacterThings> GetAllCharacterThings(Character character)
        {
            return GetAllEntity().Where(x => x.CharacterWarehouse.Id.Equals(character.CharacterWarehouse.Id));
        }
    }
}
