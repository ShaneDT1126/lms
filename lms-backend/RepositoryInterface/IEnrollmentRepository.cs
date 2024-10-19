using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IEnrollmentRepository
    {
        ICollection<Enrollment> GetAllEnrollmentsByCourse(int courseId);
        ICollection<Enrollment> GetAllEnrollmentsByStudent(int studentId);
    }
}
