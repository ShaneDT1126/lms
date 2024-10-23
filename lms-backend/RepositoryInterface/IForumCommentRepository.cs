using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IForumCommentRepository
    {
        ICollection<ForumComment> GetAllForumComments();
        ForumComment GetForumCommentById(int id);
    }
}
