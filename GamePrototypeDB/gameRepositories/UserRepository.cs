using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.user;

namespace GamePrototypeDB.gameRepositories
{
    public class UserRepository : BaseRepository<UserProfile>
    {
        public override IQueryable<UserProfile> GetAll()
        {
            return Context.UserProfile
                .Include(x => x.UserCharacter)
                .Include(x => x.UserSex);
        }
    }
}
