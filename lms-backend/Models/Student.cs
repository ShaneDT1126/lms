using lms_backend.Models.Base;

namespace lms_backend.Models
{
    public class Student : User
    {
        public List<Enrollment> Enrollments { get; set; } = [];
        public List<LessonProgression> LessonProgressions { get; set; } = [];
        public List<QuizManagement> QuizManagement { get; set; } = [];
        public List<Forum> Forums { get; set; } = [];
        public List<ForumComment> ForumComments { get; set; } = [];
    }
}
