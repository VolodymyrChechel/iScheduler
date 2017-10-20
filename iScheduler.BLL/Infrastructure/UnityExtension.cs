using iScheduler.DAL.EF;
using iScheduler.DAL.Interfaces;
using iScheduler.DAL.Repositories;
using Microsoft.Practices.Unity;

namespace iScheduler.BLL.Infrastructure
{
    public class UnityExtension : UnityContainerExtension
    {
        private string _connectionString;

        public UnityExtension(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Initialize()
        {
            //this.Container.RegisterInstance<IUnitOfWork>(new EfUnitOfWork(_connectionString));
            //this.Container.RegisterType<SchoolContext>(
            //    new InjectionConstructor(_connectionString));
            this.Container.RegisterType<IUnitOfWork, EfUnitOfWork>(
                new InjectionConstructor(_connectionString));
        }

    }
}
