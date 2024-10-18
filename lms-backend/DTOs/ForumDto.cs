using lms_backend.Models.Base;
using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class ForumDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public List<ForumComment> ForumComments { get; set; } = [];
    }
}
