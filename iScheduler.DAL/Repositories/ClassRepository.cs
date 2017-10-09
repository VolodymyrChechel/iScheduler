using iScheduler.DAL.EF;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Repositories
{
    public class ClassRepository : IRepository<Class>
    {
        private SchoolContext db;

        public ClassRepository(SchoolContext context)
        {
            db = context;
        }

        public IQueryable<Class> GetAll()
        {
            return db.Classes;
        }

        public Class Get(int id)
        {
            return db.Classes.Find(id);
        }

        public IQueryable<Class> Find(Func<Class, bool> predicate)
        {
            return db.Classes.Where(predicate).AsQueryable();
        }

        public void Create(Class item)
        {
            db.Classes.Add(item);
        }

        public void Update(Class item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Class item = db.Classes.Find(id);

            if (item == null)
                db.Classes.Remove(item);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
