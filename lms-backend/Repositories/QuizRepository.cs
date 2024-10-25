using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly DataContext _dataContext;

        public QuizRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public ICollection<Quiz> GetAllQuiz()
        {
            var quiz = _dataContext.Quiz.OrderBy(q => q.Id).ToList();

            if (quiz == null || quiz.Count == 0)
            {
                return null;
            }

            return quiz;
        }

        public Quiz GetQuizById(int id)
        {
            var quiz = _dataContext.Quiz.FirstOrDefault(q => q.Id == id);

            if (quiz == null)
            {
                return null;
            }

            return quiz;
        }
    }
}
