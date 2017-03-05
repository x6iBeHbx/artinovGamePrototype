using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeDB;

namespace GamePrototypeLogic
{
    public class BaseBusinessLogic<T> where T : IdEntity
    {
        protected readonly BaseRepository<T> Repository;
        public BaseBusinessLogic()
        {
            Repository = new BaseRepository<T>();
        }
    }
}
