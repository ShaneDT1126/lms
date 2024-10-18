namespace lms_backend.DTOs
{
    public class LessonDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
