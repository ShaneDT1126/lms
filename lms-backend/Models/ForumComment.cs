namespace lms_backend.Models
{
    public class ForumComment
    {
        public int ForumId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Forum Forum { get; set; }
        public string Comment { get; set; }
    }
}
