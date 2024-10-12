namespace lms_backend.Models
{
    public class Post
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
