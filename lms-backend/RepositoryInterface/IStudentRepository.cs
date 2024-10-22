using lms_backend.Models;

namespace lms_backend.Interface
{
    public interface IStudentRepository
    {
        ICollection<Student> GetAllStudents();
        Student? GetStudentById(int id);
        ICollection<Enrollment> GetAllEnrollmentsByStudent(int studentId);
    }
}
