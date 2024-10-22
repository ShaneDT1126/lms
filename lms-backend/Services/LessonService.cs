using lms_backend.DTOs;
using lms_backend.Models;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _repository;

        public LessonService(ILessonRepository repository)
        {
            _repository = repository;
        }

        public Lesson GetLessonById(int id)
        {
            var lesson = _repository.GetLessonById(id);

            if (lesson == null)
            {
                return null;
            }

            return lesson;
        }
    }
}
