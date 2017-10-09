using iScheduler.DAL.EF;
using iScheduler.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Repositories
{
    public class GenericRepository<C, T> : IRepository<T> where T : class where C : SchoolContext
    {
        private C db;

        public GenericRepository(C context)
        {
            db = context;
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }
        
        public IQueryable<T> Find(Func<T, bool> predicate)
        {
            return db.Set<T>().Where(predicate).AsQueryable<T>();
        }

        public void Create(T item)
        {
            db.Set<T>().Add(item);
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T item = db.Set<T>().Find(id);

            if (item != null)
                db.Set<T>().Remove(item);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
