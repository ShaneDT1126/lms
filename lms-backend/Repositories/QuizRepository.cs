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

        public ICollection<QuizManagement> GetAllQuizManagementByQuiz(int quizId)
        {
            var quiz = _dataContext.Quiz.FirstOrDefault(q => q.Id == quizId);

            if (quiz == null)
            {
                return null;
            }

            var quizManagement = quiz.QuizManagements.ToList();

            if (quizManagement == null || quizManagement.Count == 0)
            {
                return null;
            }

            return quizManagement;
        }

        public ICollection<Question> GetAllQuestionByQuiz(int quizId)
        {
            var quiz = _dataContext.Quiz.FirstOrDefault(q => q.Id == quizId);

            if (quiz == null)
            {
                return null;
            }

            var quizQuestions = quiz.Questions.ToList();

            if (quizQuestions == null || quizQuestions.Count == 0)
            {
                return null;
            }

            return quizQuestions;
        }
    }
}
