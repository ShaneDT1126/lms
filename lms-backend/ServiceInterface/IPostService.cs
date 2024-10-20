using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IPostService
    {
        PostDto GetPostById(int id);
        ICollection<PostDto> GetAllPosts();
    }
}
