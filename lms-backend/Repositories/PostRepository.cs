using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly DataContext _dataContext;

        public PostRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public Post GetPostById(int id)
        {
            var post = _dataContext.Posts.FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return null;
            }

            return post;
        }

        public ICollection<Post> GetAllPosts()
        {
            var posts = _dataContext.Posts.ToList();

            return posts;
        }
    }
}
