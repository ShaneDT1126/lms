namespace lms_backend.Models
{
    public class QuizManagement
    {
        public int QuizId { get; set; }
        public int StudentId { get; set; }
        public Quiz Quiz { get; set; }
        public Student Student { get; set; }
        public int Score { get; set; }
    }
}
