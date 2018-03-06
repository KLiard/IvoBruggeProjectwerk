namespace CourseScheduler.Dto.Models
{
    public class ModuleDto
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Naam { get; set; }

        public int Lestijden { get; set; }

        public string Studierichting { get; set; }
    }
}