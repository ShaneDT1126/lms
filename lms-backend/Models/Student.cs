namespace lms_backend.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<Enrollment> Enrollments { get; set; } = [];
        public List<LessonProgression> LessonProgressions { get; set; } = [];
        public List<QuizManagement> QuizManagement { get; set; } = [];
        public List<Forum> Forums { get; set; } = [];
        public List<ForumComment> ForumComments { get; set; } = [];
    }
}
