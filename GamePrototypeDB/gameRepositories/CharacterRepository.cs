using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.character;

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
    }
}
