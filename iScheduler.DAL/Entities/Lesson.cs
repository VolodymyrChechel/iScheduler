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
        public TimeSpan? Time { get; set; }
        public DayOfWeek DayOfWeek {get; set;}
        
        public string Name { get; set; }


        // merge lesson with shedule
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
