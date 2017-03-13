using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.game.thinks;

namespace GamePrototypeDB.gameRepositories
{
    public class ThingsRepository : BaseRepository<Things>
    {
        public override IQueryable<Things> GetAll()
        {
            return Context.Things
                .Include(x => x.SpecialThingBonus);
        }
    }
}
