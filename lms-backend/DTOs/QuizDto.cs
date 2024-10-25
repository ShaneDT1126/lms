using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class QuizDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public Lesson Lesson { get; set; }
        public int TotalScore { get; set; }

        public List<Question> Questions { get; set; }
    }
}
