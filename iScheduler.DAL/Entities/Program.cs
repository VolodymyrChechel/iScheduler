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
        public int SchoolYearId { get; set; }
        public virtual SchoolYear SchollYear { get; set; }
    }
}