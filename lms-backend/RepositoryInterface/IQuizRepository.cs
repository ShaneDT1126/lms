using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IQuizRepository
    {
        ICollection<Quiz> GetAllQuiz();
        Quiz GetQuizById(int id);
    }
}
