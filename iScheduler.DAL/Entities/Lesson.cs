using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    public class Lesson
    {
        public int Id { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
