namespace lms_backend.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public List<ForumComment> ForumComments { get; set; }
    }
}
