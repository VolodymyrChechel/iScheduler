using System;

namespace iScheduler.BLL.DTO
{
    public class SemesterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }

        //public virtual SchoolYear SchoolYear {get; set;}
        //public virtual ICollection<Program> Programs { get; set; }
    }
}
