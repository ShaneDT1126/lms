using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IForumCommentService
    {
        ICollection<ForumCommentDto> GetAllForumComments();
        ForumCommentDto GetForumCommentById(int id);
    }
}
