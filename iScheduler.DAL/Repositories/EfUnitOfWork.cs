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
        private GenericRepository<SchoolContext, Subject> subjectRepository;
        private GenericRepository<SchoolContext, Program> programRepository;
        private GenericRepository<SchoolContext, Semester> semesterRepository;
        private GenericRepository<SchoolContext, Schedule> scheduleRepository;

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

        public IRepository<Subject> Subjects
        {
            get
            {
                if (subjectRepository == null)
                    subjectRepository = new GenericRepository<SchoolContext, Subject>(db);
                return subjectRepository;
            }
        }

        public IRepository<Program> Programs
        {
            get
            {
                if(programRepository == null)
                    programRepository = new GenericRepository<SchoolContext, Program>(db);
                return programRepository;
            }
        }

        public IRepository<Semester> Semesters
        {
            get
            {
                if (semesterRepository == null)
                    semesterRepository = new GenericRepository<SchoolContext, Semester>(db);
                return semesterRepository;
            }
        }

        public IRepository<Schedule> Schedules
        {
            get
            {
                if (scheduleRepository == null)
                    scheduleRepository = new GenericRepository<SchoolContext, Schedule>(db);
                return scheduleRepository;
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
