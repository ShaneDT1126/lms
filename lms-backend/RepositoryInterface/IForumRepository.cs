using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IForumRepository
    {
        ICollection<Forum> GetAllForums();
        Forum GetForumById(int id);

        ICollection<ForumComment> GetAllForumCommentsByForum(int forumId);
    }
}
