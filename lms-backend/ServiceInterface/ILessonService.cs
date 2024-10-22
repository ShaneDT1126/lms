using lms_backend.DTOs;
using lms_backend.Models;

namespace lms_backend.ServiceInterface
{
    public interface ILessonService
    {
        Lesson GetLessonById(int id);
    }
}
