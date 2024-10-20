using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
