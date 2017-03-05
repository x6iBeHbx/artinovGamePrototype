using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeDB.gameRepositories
{
    class ThingsRepository : BaseRepository<Things>
    {
        public override IQueryable<Things> GetAll()
        {
            return Context.Things
                .Include(x => x.SpecialThingBonus)
                .Include(x => x.ThingsType);
        }
    }
}
