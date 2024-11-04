using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public ICollection<QuestionDto> GetAllQuestions()
        {
            var questions = _questionRepository.GetAllQuestions();

            if (questions == null)
            {
                return null;
            }

            var questionDto = questions.Select(q => new QuestionDto
            {
                Id = q.Id,
                Title = q.Title,
                Choices = q.Choices,
                StudentAnswer = q.StudentAnswer,
                CorrectAnswer = q.CorrectAnswer
            }).ToList();

            return questionDto;
        }
    }
}
