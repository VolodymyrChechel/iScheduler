using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.Entities
{
    public class Schedule
    {
        public int Id{ get; set; }

        public int LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int LectureRoomId { get; set; }
        public virtual LectureRoom LectureRoom { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
