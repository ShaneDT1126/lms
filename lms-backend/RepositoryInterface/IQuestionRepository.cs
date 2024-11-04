using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IQuestionRepository
    {
        ICollection<Question> GetAllQuestions();
    }
}
