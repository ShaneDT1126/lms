using lms_backend.DTOs;
using lms_backend.Models;

namespace lms_backend.ServiceInterface
{
    public interface ILessonService
    {
        ICollection<LessonDto>GetAllLessonByCourse(int courseId);
        Lesson GetLessonById(int id);
    }
}
