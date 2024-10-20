using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public PostDto GetPostById(int id)
        {
            var post = _postRepository.GetPostById(id);

            if (post == null)
            {
                return null;
            }

            var postDto = new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                CourseId = post.CourseId,
                TeacherId = post.TeacherId,
                Course = post.Course,
                Teacher = post.Teacher,

            };

            return postDto;
        }

        public ICollection<PostDto> GetAllPosts()
        {
            var posts = _postRepository.GetAllPosts();

            if (posts == null || !posts.Any())
            {
                return null;
            }

            var postsDto = posts.Select(p => new PostDto
            {
                Id = p.Id, 
                Title = p.Title,
                Content = p.Content,
                CourseId = p.CourseId,
                TeacherId = p.TeacherId,
                Course = p.Course,
                Teacher = p.Teacher,
            }).ToList();

            return postsDto;
        }
    }
}
