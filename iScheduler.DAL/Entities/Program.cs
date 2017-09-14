using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    public class Program
    {
        public int Id { get; set; }
        public int Hours { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }
    }
}