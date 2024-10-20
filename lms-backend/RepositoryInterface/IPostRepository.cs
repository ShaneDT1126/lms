using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IPostRepository
    {
        Post GetPostById(int id);
        ICollection<Post> GetAllPostByCourse(int courseId);
        ICollection<Post> GetPostByTeacher(int teacherId);
    }
}
