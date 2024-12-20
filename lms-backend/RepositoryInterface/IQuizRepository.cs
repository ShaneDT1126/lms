﻿using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface IQuizRepository
    {
        ICollection<Quiz> GetAllQuiz();
        Quiz GetQuizById(int id);
        ICollection<QuizManagement> GetAllQuizManagementByQuiz(int quizId);
        ICollection<Question> GetAllQuestionByQuiz(int quizId);
    }
}
