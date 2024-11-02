namespace lms_backend.DTOs
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Choices { get; set; } = [];
        public string StudentAnswer { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; }
    }
}
