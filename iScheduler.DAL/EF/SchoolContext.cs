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
        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(
                new SchoolDbInitializer());
        }

        public SchoolContext(string connectionString) : base(connectionString)
        {

        }

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
    }

    // set inital data into database
    public class SchoolDbInitializer : 
        DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext db)
        {
            // adding rooms
            var room21 = db.LectureRooms.Add(new LectureRoom { Number = "21"});
            var room24 = db.LectureRooms.Add(new LectureRoom { Number = "24"});
            var room25 = db.LectureRooms.Add(new LectureRoom { Number = "25"});
            var room26 = db.LectureRooms.Add(new LectureRoom { Number = "26"});
            var room27 = db.LectureRooms.Add(new LectureRoom { Number = "27"});
            var room28 = db.LectureRooms.Add(new LectureRoom { Number = "28"});
            var room33 = db.LectureRooms.Add(new LectureRoom { Number = "33"});
            var room35 = db.LectureRooms.Add(new LectureRoom { Number = "35" });
            var room36 = db.LectureRooms.Add(new LectureRoom { Number = "36" });
            var room37 = db.LectureRooms.Add(new LectureRoom { Number = "37" });
            var room38 = db.LectureRooms.Add(new LectureRoom { Number = "38" });

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
            var subMath = db.Subjects.Add(new Subject {Name = "Математика"});
            var subUkrLang = db.Subjects.Add(new Subject { Name = "Українська мова" });
            var subUkrLit = db.Subjects.Add(new Subject { Name = "Українська література" });
            var subEngLang = db.Subjects.Add(new Subject { Name = "Англыйська мова" });
            var subForLit = db.Subjects.Add(new Subject { Name = "Світова література" });
            var subPhys = db.Subjects.Add(new Subject { Name = "Фізика" });
            var subAlg = db.Subjects.Add(new Subject { Name = "Алгебра" });
            var subGeom = db.Subjects.Add(new Subject { Name = "Геометрія" });
            var subGeogr = db.Subjects.Add(new Subject { Name = "Географія" });
            var subChem = db.Subjects.Add(new Subject { Name = "Хімія" });
            var subInform = db.Subjects.Add(new Subject { Name = "Інформатика" });
            var subBiol = db.Subjects.Add(new Subject { Name = "Біологія" });
            var subUkrHist = db.Subjects.Add(new Subject { Name = "Історія України" });
            var subWorldHist = db.Subjects.Add(new Subject { Name = "Всесвітня історія" });
            var subSport = db.Subjects.Add(new Subject { Name = "Фізична культура" });

            // adding lessons
            var durationOfLesson = new TimeSpan(0, 45, 0);
            var numberOfWorkingDays = 5;
            var startOfDay = new TimeSpan(8, 30, 0);
            var finishOfDay = new TimeSpan(16, 0, 0);
            var durationOfSmallBreak = new TimeSpan(0, 10, 0);
            var durationOfLongBreak = new TimeSpan(0, 20, 0);
            var longBreaksNumber = new List<int> { 3, 4};
            var startOfWorkingWeek = 1; // for monday

            var LessonsList = new List<Lesson>();
            // generate timings
            for (int i = startOfWorkingWeek; i < startOfWorkingWeek + numberOfWorkingDays; i++)
            {
                var counter = 1;
                for (TimeSpan ts = startOfDay; ts < finishOfDay; ts = ts.Add(durationOfLesson))
                {
                    LessonsList.Add(
                        db.Lessons.Add(new Lesson { Time = ts, DayOfWeek = (DayOfWeek)i,
                        Name = $"{counter} lesson of {(DayOfWeek)i}"}
                        ));
                    ++counter;

                    if (longBreaksNumber.Where(lesson => lesson == counter).Any())
                        ts = ts.Add(durationOfLongBreak);
                    else
                        ts = ts.Add(durationOfSmallBreak);
                }
            }

#region Programs
            // adding program
            db.Programs.Add(new Program() { Class = clss5, Hours = 3, Subject = subMath, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 4, Subject = subUkrLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 2, Subject = subUkrLit, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 4, Subject = subEngLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 2, Subject = subInform, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 2, Subject = subPhys, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 2, Subject = subSport, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 1, Subject = subUkrHist, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss5, Hours = 1, Subject = subWorldHist, Semester = sms2017frst });

            db.Programs.Add(new Program() { Class = clss6, Hours = 3, Subject = subMath, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 4, Subject = subUkrLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subUkrLit, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 4, Subject = subEngLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subInform, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subPhys, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subSport, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subUkrHist, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subWorldHist, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subChem, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subGeogr, Semester = sms2017frst });

            db.Programs.Add(new Program() { Class = clss6, Hours = 3, Subject = subMath, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 4, Subject = subUkrLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subUkrLit, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 4, Subject = subEngLang, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subInform, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subPhys, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subSport, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subUkrHist, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subWorldHist, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 1, Subject = subChem, Semester = sms2017frst });
            db.Programs.Add(new Program() { Class = clss6, Hours = 2, Subject = subGeogr, Semester = sms2017frst });
#endregion

            var schedule = db.Schedules.Add(new Schedule
            {
                Class = clss5,
                LectureRoom = room24,
                Lesson = LessonsList[2],
                Subject = subGeogr,
                Teacher = tch1
            });

            base.Seed(db);
        }
    }
}
