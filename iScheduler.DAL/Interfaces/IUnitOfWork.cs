using iScheduler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Class> Classes { get; }
        IRepository<Teacher> Teachers { get; }
        IRepository<Subject> Subjects { get; }
        IRepository<Program> Programs { get; }
        IRepository<Semester> Semesters { get; }
        IRepository<Schedule> Schedules { get; }

        void Save();
    }
}
