using iScheduler.DAL.Entities;
using System.Collections.Generic;

namespace iScheduler.BLL.DTO
{
    public class ClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual SchoolYear SchoolYear { get; set; }
        public virtual Teacher FormTeacher { get; set; }
        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
