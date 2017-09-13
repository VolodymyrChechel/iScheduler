using iScheduler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.EF
{
    public class SchoolContext : DbContext
    {
        public IDbSet<Class> Classes { get; set; }
        public IDbSet<Lesson> Lessons { get; set; }
        public IDbSet<Phone> Phones { get; set; }
        public IDbSet<Program> Programs{ get; set; }
        public IDbSet<Pupil> Pupils{ get; set; }
        public IDbSet<SchoolYear> SchoolYears { get; set; }
        public IDbSet<Subject> Subjects{ get; set; }
        public IDbSet<Teacher> Teachers{ get; set; }

        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(
                new DropCreateDatabaseIfModelChanges<SchoolContext>());
        }
    }
}
