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
    public class CharacterServerLogic : BaseBusinessLogic<Character>
    {
        private readonly CharacterRepository _characterRepository = new CharacterRepository();
        private readonly CharacterThingsServerLogic _characterThingsServerLogic = new CharacterThingsServerLogic();
        public IEnumerable<Character> GetAllCharacter()
        {
            return _characterRepository.GetAll();
        }
        public IEnumerable<Character> GetAllCharacterByLevel(int level)
        {
            return _characterRepository.GetAll().Where(x => x.Level.Equals(level));
        }
        public IEnumerable<Character> GetAllCharacterByType(CharacterTypeEnum type)
        {
            return _characterRepository.GetAll().Where(x => x.CharacterType.Equals(type));
        }

        public override Character GetEntityById(Guid id)
        {
            return _characterRepository.GetById(id);
        }

        public Character GetCharacterByNickName(string name)
        {
            return _characterRepository.GetAll().FirstOrDefault(x => x.Name.Equals(name));
        }
    }
}
