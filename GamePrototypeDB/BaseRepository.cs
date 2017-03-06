using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GamePrototypeClasses.core;

namespace GamePrototypeDB
{
    public class BaseRepository<T> where T : IdEntity
    {
        protected readonly GameDBContext Context;
        public BaseRepository()
        {
            Context = new GameDBContext();
        }

        public virtual IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }
        public void RemoveAt(Guid id)
        {
            T entity = Context.Set<T>().Find(id);
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual T GetById(Guid id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
