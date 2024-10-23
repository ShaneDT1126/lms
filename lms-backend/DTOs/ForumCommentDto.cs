using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class ForumCommentDto
    {
        public int Id { get; set; }
        public int ForumId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Forum Forum { get; set; }
        public string Comment { get; set; }
    }
}
