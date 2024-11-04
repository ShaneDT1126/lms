using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IQuestionService
    {
        ICollection<QuestionDto> GetAllQuestions();
    }
}
