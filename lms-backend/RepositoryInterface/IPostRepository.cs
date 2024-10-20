using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IPostRepository
    {
        Post GetPostById(int id);
        ICollection<Post> GetAllPosts();
    }
}
