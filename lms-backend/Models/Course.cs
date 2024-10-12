namespace lms_backend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public Teacher Teacher { get; set; }
        public List<Enrollment> Enrollments { get; set; } = [];
        public List<Lesson> Lessons { get; set; }



    }
}
