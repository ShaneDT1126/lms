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

    }
}
