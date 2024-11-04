using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context)
        {
            _context = context;
        }


        public ICollection<Question> GetAllQuestions()
        {
            var questions = _context.Question.OrderBy(q => q.Id).ToList();

            if (questions.Count > 0 || questions == null)
            {
                return null;
            }

            return questions;
        }
    }
}
