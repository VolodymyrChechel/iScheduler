using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    // class represents Teacher entity
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
