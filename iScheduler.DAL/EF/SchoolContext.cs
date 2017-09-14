using iScheduler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.DAL.EF
{
    public class SchoolContext : DbContext
    {
        public IDbSet<Class> Classes { get; set; }
        public IDbSet<LectureRoom> LectureRooms { get; set; }
        public IDbSet<Lesson> Lessons { get; set; }
        public IDbSet<Phone> Phones { get; set; }
        public IDbSet<Program> Programs{ get; set; }
        public IDbSet<Schedule> Schedules { get; set; }
        public IDbSet<Pupil> Pupils{ get; set; }
        public IDbSet<SchoolYear> SchoolYears { get; set; }
        public IDbSet<Semester> Semesters { get; set; }
        public IDbSet<Subject> Subjects{ get; set; }
        public IDbSet<Teacher> Teachers{ get; set; }

        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(
                new SchoolDbInitializer());
        }
    }

    // set inital data into database
    public class SchoolDbInitializer : 
        DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext db)
        {
            // adding rooms
            db.LectureRooms.Add(new LectureRoom { Number = "21"});
            db.LectureRooms.Add(new LectureRoom { Number = "24"});
            db.LectureRooms.Add(new LectureRoom { Number = "25"});
            db.LectureRooms.Add(new LectureRoom { Number = "26"});
            db.LectureRooms.Add(new LectureRoom { Number = "27"});
            db.LectureRooms.Add(new LectureRoom { Number = "28"});
            db.LectureRooms.Add(new LectureRoom { Number = "33"});
            db.LectureRooms.Add(new LectureRoom { Number = "35" });
            db.LectureRooms.Add(new LectureRoom { Number = "36" });
            db.LectureRooms.Add(new LectureRoom { Number = "37" });
            db.LectureRooms.Add(new LectureRoom { Number = "38" });

            // adding years
            var sy78 = db.SchoolYears.Add(new SchoolYear { Name="2017/2018" });
            var sy89 = db.SchoolYears.Add(new SchoolYear { Name="2019/2017" });

            // adding semesters
            var sms2017frst = db.Semesters.Add(new Semester { Name = "2017/2018 1st semester", SchoolYear = sy78, Start = new DateTime(2017, 9, 1), Finish = new DateTime(2017, 12, 29)});
            var sms2017scnd = db.Semesters.Add(new Semester { Name = "2017/2018 2st semester", SchoolYear = sy78, Start = new DateTime(2018, 1, 15), Finish = new DateTime(2017, 12, 29) });

            // adding classes 
            var clss1 = db.Classes.Add(new Class { Name = "1st grade", SchoolYear = sy78 });
            var clss2 = db.Classes.Add(new Class { Name = "2nd grade", SchoolYear = sy78 });
            var clss3 = db.Classes.Add(new Class { Name = "3rd grade", SchoolYear = sy78 });
            var clss4 = db.Classes.Add(new Class { Name = "4th grade", SchoolYear = sy78 });
            var clss5 = db.Classes.Add(new Class { Name = "5th grade", SchoolYear = sy78 });
            var clss6 = db.Classes.Add(new Class { Name = "6th grade", SchoolYear = sy78 });
            var clss7 = db.Classes.Add(new Class { Name = "7th grade", SchoolYear = sy78 });
            var clss8 = db.Classes.Add(new Class { Name = "8th grade", SchoolYear = sy78 });
            var clss9 = db.Classes.Add(new Class { Name = "9th grade", SchoolYear = sy78 });
            var clss10 = db.Classes.Add(new Class { Name = "10th grade", SchoolYear = sy78 });
            var clss11 = db.Classes.Add(new Class { Name = "11th grade", SchoolYear = sy78 });

            // adding teachers
            var tch1 = db.Teachers.Add(new Teacher { Surname = "Чечель", Name = "Валентина", Patronymic = "Володимирівна" });
            var tch2 = db.Teachers.Add(new Teacher { Surname = "Піддубна", Name = "Валентина", Patronymic = "Василівна" });
            var tch3 = db.Teachers.Add(new Teacher { Surname = "Гребенюк", Name = "Світлана", Patronymic = "Іванівна" });
            var tch4 = db.Teachers.Add(new Teacher { Surname = "Лековкіна", Name = "Ніна", Patronymic = "Федоріна" });
            var tch5 = db.Teachers.Add(new Teacher { Surname = "Лековкін", Name = "Михайло", Patronymic = "Анатолійович" });
            var tch6 = db.Teachers.Add(new Teacher { Surname = "Рева", Name = "Тетяна", Patronymic = "Дмитрівна" });
            var tch7 = db.Teachers.Add(new Teacher { Surname = "Хижняк", Name = "Ельміра", Patronymic = "Саттарівна" });
            var tch8 = db.Teachers.Add(new Teacher { Surname = "Собрат", Name = "Микола", Patronymic = "Федорович" });

            // adding subjects
            var sub1 = db.Subjects.Add(new Subject {Name = "Математика"});
            var sub2 = db.Subjects.Add(new Subject { Name = "Українська мова" });
            var sub3 = db.Subjects.Add(new Subject { Name = "Українська література" });
            var sub4 = db.Subjects.Add(new Subject { Name = "Англыйська мова" });
            var sub5 = db.Subjects.Add(new Subject { Name = "Світова література" });
            var sub6 = db.Subjects.Add(new Subject { Name = "Фізика" });
            var sub7 = db.Subjects.Add(new Subject { Name = "Алгебра" });
            var sub8 = db.Subjects.Add(new Subject { Name = "Геометрія" });
            var sub9 = db.Subjects.Add(new Subject { Name = "Географія" });
            var sub10 = db.Subjects.Add(new Subject { Name = "Хімія" });
            var sub11 = db.Subjects.Add(new Subject { Name = "Інформатика" });
            var sub12 = db.Subjects.Add(new Subject { Name = "Біологія" });
            var sub13 = db.Subjects.Add(new Subject { Name = "Історія України" });
            var sub14 = db.Subjects.Add(new Subject { Name = "Всесвітня історія" });


            base.Seed(db);

        }
    }
}
