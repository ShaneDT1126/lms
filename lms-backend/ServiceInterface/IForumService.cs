using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IForumService
    {
        ICollection<ForumDto> GetAllForums();
        ForumDto GetForumById(int id);

        ICollection<ForumCommentDto> GetAllCommentByForum(int forumId);
    }
}
