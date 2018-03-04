using CourseScheduler.Domain.Enums;

namespace CourseScheduler.Domain.Models
{
    public class Module
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Naam { get; set; }

        public int Lestijden { get; set; }

        public Studierichting Studierichting { get; set; }
    }
}
