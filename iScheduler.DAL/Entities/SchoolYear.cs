using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    public class SchoolYear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Semester> Semesters { get; set; }

    }
}
