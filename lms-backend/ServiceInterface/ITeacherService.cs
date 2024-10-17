using lms_backend.DTOs;
using lms_backend.Models;

namespace lms_backend.ServiceInterface
{
    public interface ITeacherService
    {
        ICollection<TeacherDto> GetAllTeachers();
        TeacherDto? GetTeacherById(int id);
    }
}
