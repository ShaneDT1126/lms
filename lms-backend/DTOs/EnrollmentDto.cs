using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class EnrollmentDto
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
