using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class ForumCommentRepository : IForumCommentRepository
    {
        private readonly DataContext _context;

        public ForumCommentRepository(DataContext context)
        {
            _context = context;
        }


        public ICollection<ForumComment> GetAllForumComments()
        {
            var comments = _context.ForumComments.OrderBy(c => c.Id).ToList();

            if (comments == null || !comments.Any())
            {
                return null;
            }

            return comments;
        }

        public ForumComment GetForumCommentById(int id)
        {
            var comment = _context.ForumComments.FirstOrDefault(c => c.Id == id);

            if (comment == null)
            {
                return null;
            }

            return comment;
        }
    }
}
