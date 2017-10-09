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
        void Save();
    }
}
