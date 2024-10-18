using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class ForumRepository : IForumRepository
    {
        private readonly DataContext _dataContext;

        public ForumRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public ICollection<Forum> GetAllForums()
        {
            var forums = _dataContext.Forums.OrderBy(f => f.Id).ToList();

            if (forums == null)
            {
                return null;
            }

            return forums;
        }

        public Forum GetForumById(int id)
        {
            var forum = _dataContext.Forums.FirstOrDefault(f => f.Id == id);

            if (forum == null)
            {
                return null;
            }

            return forum;
        }
    }
}
