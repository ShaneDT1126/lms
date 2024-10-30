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

        public LessonDto GetLessonById(int id)
        {
            var lesson = _repository.GetLessonById(id);

            if (lesson == null)
            {
                return null;
            }

            var lessonDto = new LessonDto
            {
                Id = lesson.Id,
                Name = lesson.Name,
                CreatedAt = lesson.CreatedAt,
                Description = lesson.Description,
                Content = lesson.Content
            };

            return lessonDto;
        }

        public ICollection<LessonDto> GetAllLessons()
        {
            var lessons = _repository.GetAllLessons();

            if (lessons == null)
            {
                return null;
            }

            var lessonsDto = lessons.Select(l => new LessonDto
            {
                Id = l.Id,
                Name = l.Name,
                CreatedAt = l.CreatedAt,
                Description = l.Description,
                Content = l.Content
            }).ToList();

            return lessonsDto;
        }

        public ICollection<LessonProgressionDto> GetAllLessonProgressionsByLesson(int lessonId)
        {
            var lessonProgressions = _repository.GetAllLessonProgressionsByLesson(lessonId);

            if (lessonProgressions == null)
            {
                return null;
            }

            var lessonProgressionDto = lessonProgressions.Select(lp => new LessonProgressionDto
            {
                LessonId = lp.LessonId,
                StudentId = lp.StudentId,
                Lesson = lp.Lesson,
                Student = lp.Student,
                Status = lp.Status
            }).ToList();

            return lessonProgressionDto;
        }
    }
}
