using lms_backend.DTOs;


namespace lms_backend.ServiceInterface
{
    public interface IStudentService
    {
        ICollection<StudentDto> GetAllStudents();
    }
}
