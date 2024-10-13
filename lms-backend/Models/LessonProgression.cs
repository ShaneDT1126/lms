using lms_backend.Enums;

namespace lms_backend.Models
{
    public class LessonProgression
    {
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public Lesson Lesson { get; set; }
        public Student Student { get; set; }
        public LessonStatusEnum Status { get; set; }
    }
}
