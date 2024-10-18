using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class ForumService : IForumService
    {
        private readonly IForumRepository _forumRepository;

        public ForumService(IForumRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public ICollection<ForumDto> GetAllForums()
        {
            var forums = _forumRepository.GetAllForums();

            if (forums == null || !forums.Any())
            {
                return null;
            }

            var forumDto = forums.Select(f => new ForumDto
            {
                Id = f.Id,
                Title = f.Title,
                Content = f.Content,
                ForumComments = f.ForumComments,
                User = f.User
            }).ToList();

            return forumDto;
        }

        public ForumDto GetForumById(int id)
        {
            var forum = _forumRepository.GetForumById(id);

            if (forum == null)
            {
                return null;
            }

            var forumDto = new ForumDto
            {
                Id = forum.Id,
                Title = forum.Title,
                Content = forum.Content,
                ForumComments = forum.ForumComments,
                User = forum.User
            };

            return forumDto;
        }
    }
}
