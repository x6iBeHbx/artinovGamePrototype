using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;

namespace GamePrototypeDB.gameRepositories
{
    public class CharacterRepository : BaseRepository<Character>
    {
        public override IQueryable<Character> GetAll()
        {
            return Context.Set<Character>()
                .Include(x => x.CharacterWarehouse)
                .Include(x => x.CharacterEquipment);
        }

        public CharacterWarehouse GetWarehouse(Character character)
        {
            var war = Context.Set<Character>()
                .Where( x => x.Name == character.Name)
                .Select(x => x.CharacterWarehouse);

            return war.First();
        }

        public override Character GetById(Guid id)
        {
            return GetAll().FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}

