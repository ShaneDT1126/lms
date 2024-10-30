using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext _dataContext;

        public LessonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public Lesson GetLessonById(int id)
        {
            var lesson = _dataContext.Lessons.FirstOrDefault(x => x.Id == id);

            if (lesson == null)
            {
                return null;
            }

            return lesson;
        }

        public ICollection<Lesson>? GetAllLessons()
        {
            var lessons = _dataContext.Lessons.OrderBy(l => l.Id).ToList();

            if (lessons == null || !lessons.Any())
            {
                return null;
            }

            return lessons;
        }

        public ICollection<LessonProgression>? GetAllLessonProgressionsByLesson(int lessonId)
        {
            var lesson = _dataContext.Lessons.FirstOrDefault(l => l.Id == lessonId);

            if (lesson == null)
            {
                return null;
            }

            var lessonProgressions = lesson.LessonProgressions.ToList();

            if (lessonProgressions == null || !lessonProgressions.Any())
            {
                return null;
            }

            return lessonProgressions;
        }
    }
}
