using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.BLL.DTO
{
    public class ScheduleDto
    {
        public int Id{ get; set; }

        public int LessonId { get; set; }
        public string LessonName { get; set; }
        //public virtual Lesson Lesson { get; set; }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        //public virtual Teacher Teacher { get; set; }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        //public virtual Class Class { get; set; }

        public int LectureRoomId { get; set; }
        public int LectureRoomName { get; set; }
        //public virtual LectureRoom LectureRoom { get; set; }

        public int SubjectId { get; set; }
        public int SubjectName { get; set; }
        //public virtual Subject Subject { get; set; }

    }
}
