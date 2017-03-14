using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;
using GamePrototypeClasses.user;
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
        public void AddEntity(T entity)
        {
            Repository.Add(entity);
        }

        public void UpdateEntity(T entity)
        {
            Repository.Update(entity);
        }

        public IQueryable<T> GetAllEntity()
        {
            return Repository.GetAll();
        }

        public virtual T GetEntityById(Guid id)
        {
            return Repository.GetById(id);
        }

        public void RemoveEntity(T entity)
        {
            Repository.Remove(entity);
        }

        public void RemoveEntityAt(Guid id)
        {
            Repository.RemoveAt(id);
        }
    }
}
