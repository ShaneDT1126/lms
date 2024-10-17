using lms_backend.DTOs.BaseDto;
using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class StudentDto : BaseUserDto
    {
        public List<Enrollment> Enrollments { get; set; } = [];
        public List<LessonProgression> LessonProgressions { get; set; } = [];
        public List<QuizManagement> QuizManagement { get; set; } = [];
    }
}
