using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public QuizService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }


        public ICollection<QuizDto>? GetAllQuiz()
        {
            var quizzes = _quizRepository.GetAllQuiz();

            if (quizzes == null || !quizzes.Any())
            {
                return null;
            }

            var quizzesDto = quizzes.Select(q=> new QuizDto
            {
                Id = q.Id,
                Name = q.Name,
                CreatedAt = q.CreatedAt,
                Description = q.Description,
                Lesson = q.Lesson,
                TotalScore = q.TotalScore,
                Questions = q.Questions
            }).ToList();

            return quizzesDto;
        }

        public QuizDto GetQuizById(int id)
        {
            var quiz = _quizRepository.GetQuizById(id);

            if (quiz == null)
            {
                return null;
            }

            var quizDto = new QuizDto
            {
                Id = quiz.Id,
                Name = quiz.Name,
                CreatedAt = quiz.CreatedAt,
                Description = quiz.Description,
                Lesson = quiz.Lesson,
                TotalScore = quiz.TotalScore,
                Questions = quiz.Questions
            };

            return quizDto;
        }
    }
}
