using iScheduler.DAL.EF;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Repositories
{
    public class EfUnitOfWork : IUnitOfWork
    {
        bool disposed;
        private SchoolContext db;
        private GenericRepository<SchoolContext, Class> classRepository;
        private GenericRepository<SchoolContext, Teacher> teacherRepository;

        public EfUnitOfWork(string connectionString)
        {
            db = new SchoolContext(connectionString);
        }

        public IRepository<Class> Classes
        {
            get
            {
                if (classRepository == null)
                    classRepository = new GenericRepository<SchoolContext, Class>(db);
                return classRepository;
            }
        }

        public IRepository<Teacher> Teachers
        {
            get
            {
                if (teacherRepository == null)
                    teacherRepository = new GenericRepository<SchoolContext, Teacher>(db);
                return teacherRepository;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
