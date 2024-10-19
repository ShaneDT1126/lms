using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface ICourseRepository
    {
        ICollection<Course> GetAllCourses();
        Course GetCourseById(int id);
    }
}
