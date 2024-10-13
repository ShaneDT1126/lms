using lms_backend.Models.Base;

namespace lms_backend.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public List<ForumComment> ForumComments { get; set; } = [];
    }
}
