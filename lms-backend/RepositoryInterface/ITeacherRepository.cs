using lms_backend.Models;

namespace lms_backend.Interface
{
    public interface ITeacherRepository
    {
        ICollection<Teacher> GetAllTeachers();
        Teacher? GetTeacherById(int id);
    }
}
