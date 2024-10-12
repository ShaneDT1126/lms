namespace lms_backend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Choices { get; set; }
        public string Answer { get; set; }
    }
}
