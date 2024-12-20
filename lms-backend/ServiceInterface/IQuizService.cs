﻿using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface IQuizService
    {
        ICollection<QuizDto> GetAllQuiz();
        QuizDto GetQuizById(int id);
        ICollection<QuizManagementDto> GetAllQuizManagementByQuiz(int quizId);
        ICollection<QuestionDto> GetAllQuestionByQuiz(int quizId);
    }
}
