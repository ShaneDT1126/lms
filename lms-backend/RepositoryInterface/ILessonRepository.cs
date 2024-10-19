using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface ILessonRepository
    {
        Lesson GetLessonById(int id);
        ICollection<Lesson> GetLessonByCourse(int courseId);
    }
}
