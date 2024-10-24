using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class ForumCommentService : IForumCommentService
    {
        private readonly IForumCommentRepository _forumCommentRepository;

        public ForumCommentService(IForumCommentRepository forumCommentRepository)
        {
            _forumCommentRepository = forumCommentRepository;
        }


        public ICollection<ForumCommentDto>? GetAllForumComments()
        {
            var comments = _forumCommentRepository.GetAllForumComments();

            if (comments == null || !comments.Any())
            {
                return null;
            }

            var commentDto = comments.Select(c => new ForumCommentDto
            {
                Id = c.Id,
                ForumId = c.ForumId,
                StudentId = c.StudentId,
                Forum = c.Forum,
                Student = c.Student,
                Comment = c.Comment
            }).ToList();

            return commentDto;
        }

        public ForumCommentDto GetForumCommentById(int id)
        {
            var comment = _forumCommentRepository.GetForumCommentById(id);

            if (comment == null)
            {
                return null;
            }

            var commentDto = new ForumCommentDto
            {
                Id = comment.Id,
                ForumId = comment.ForumId,
                StudentId = comment.StudentId,
                Forum = comment.Forum,
                Student = comment.Student,
                Comment = comment.Comment
            };

            return commentDto;
        }
    }
}
