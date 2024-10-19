using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;

        public CourseRepository(DataContext context)
        {
            _context = context;
        }


        public ICollection<Course> GetAllCourses()
        {
            var courses = _context.Courses.OrderBy(c => c.Id).ToList();

            if (courses == null)
            {
                return null;
            }

            return courses;
        }

        public Course GetCourseById(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return null;
            }

            return course;
        }

        public ICollection<Lesson> GetAllLessonsByCourse(int courseId)
        {
            var lessons = _context.Courses.Where(c => c.Id == courseId).;

         
        }
    }
}
