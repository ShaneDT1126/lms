namespace lms_backend.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public Course Course { get; set; }
        public string Content { get; set; } = string.Empty;
        public List<Quiz> Quizzes { get; set; } = [];
        public List<LessonProgression> LessonProgressions { get; set; } = [];



    }
}
