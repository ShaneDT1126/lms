using lms_backend.DTOs;
using lms_backend.Models;

namespace lms_backend.ServiceInterface
{
    public interface ILessonService
    {
        LessonDto GetLessonById(int id);
        ICollection<LessonDto> GetAllLessons();
        ICollection<LessonProgressionDto> GetAllLessonProgressionsByLesson(int lessonId);

    }
}
