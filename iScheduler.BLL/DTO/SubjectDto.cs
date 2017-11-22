using iScheduler.DAL.Entities;
using System.Collections.Generic;

namespace iScheduler.BLL.DTO
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
