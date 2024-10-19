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

        public ICollection<Lesson> GetLessonByCourse(int courseId)
        {
            var course = _dataContext.Courses.FirstOrDefault(c => c.Id == courseId);

            if (course.Lessons == null)
            {
                return null;
            }

            var lessons = course.Lessons.ToList();

            return lessons;
        }
    }
}
