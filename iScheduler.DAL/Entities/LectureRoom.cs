using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    public class LectureRoom
    {
        public int Id { get; set;}
        public string Number { get; set;}
        public string Comment { get; set; }

        public virtual ICollection<Schedule> ScheduleItems { get; set; }
    }
}
