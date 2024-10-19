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


        public ICollection<LessonDto> GetAllLessonByCourse(int courseId)
        {
            var lessons = _repository.GetLessonByCourse(courseId);

            if (lessons == null || !lessons.Any())
            {
                return null;
            }

            var lessonsDto = lessons.Select(l => new LessonDto
            {
                Id = l.Id,
                Name = l.Name,
                Content = l.Content,
                CreatedAt = l.CreatedAt,
                Description = l.Description
            }).ToList();

            return lessonsDto;

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
