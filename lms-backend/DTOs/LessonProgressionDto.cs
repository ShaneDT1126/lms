using lms_backend.Enums;
using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class LessonProgressionDto
    {
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public Lesson Lesson { get; set; }
        public Student Student { get; set; }
        public LessonStatusEnum Status { get; set; }
    }
}
