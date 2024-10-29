using lms_backend.Models;

namespace lms_backend.Interface
{
    public interface IStudentRepository
    {
        ICollection<Student> GetAllStudents();
        Student? GetStudentById(int id);
        ICollection<Enrollment> GetAllEnrollmentsByStudent(int studentId);
        ICollection<ForumComment> GetAllForumCommentsByStudent(int studentId);
        ICollection<QuizManagement> GetAllQuizManagementByStudent(int studentId);
        ICollection<LessonProgression>? GetAllLessonProgressionByStudent(int studentId);
    }
}
