using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _dataContext;

        public TeacherRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<Teacher> GetAllTeachers()
        {
            var teachers = _dataContext.Teachers.OrderBy(t => t.Id).ToList();

            if (teachers == null)
            {
                return null;
            }

            return teachers;
        }

        public Teacher? GetTeacherById(int id)
        {
            var teacher = _dataContext.Teachers.FirstOrDefault(t => t.Id == id);

            if (teacher == null)
            {
                return null;
            }

            return teacher;
        }
    }
}
