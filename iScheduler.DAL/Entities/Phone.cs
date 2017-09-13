using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    // class represents Phone entity for Teacher
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
