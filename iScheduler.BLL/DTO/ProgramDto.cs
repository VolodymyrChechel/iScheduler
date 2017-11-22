namespace iScheduler.BLL.DTO
{
    public class ProgramDto
    {
        public int Id { get; set; }
        public int Hours { get; set; }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        //public virtual Class Class { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        //public virtual Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        //public virtual Semester Semester { get; set; }
    }
}