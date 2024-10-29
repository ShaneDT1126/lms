using lms_backend.Data;
using lms_backend.Interface;
using lms_backend.Models;


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

        public ICollection<Course>? GetAllCoursesByTeacher(int teacherId)
        {
            var teacher = _dataContext.Teachers.FirstOrDefault(t => t.Id == teacherId);

            if (teacher == null)
            {
                return null;
            }

            var teacherCourses = teacher.Courses.ToList();

            if (!teacherCourses.Any() || teacherCourses.Count() == 0)
            {
                return null;
            }

            return teacherCourses;
        }
    }
}
