using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IEnrollmentService
    {
        ICollection<EnrollmentDto> GetAllEnrollmentsByCourse(int courseId);
        ICollection<EnrollmentDto> GetALlEnrollmentsByStudent(int studentId);
    }
}
