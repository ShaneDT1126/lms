﻿using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/quizzes")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public ActionResult GetAllQuiz()
        {
            var quizzes = _quizService.GetAllQuiz();

            if (quizzes == null)
            {
                return NotFound("No Quizzes Found");
            }

            return Ok(quizzes);
        }

        [HttpGet("{id}")]
        public ActionResult GetQuizById(int id)
        {
            var quiz = _quizService.GetQuizById(id);

            if (quiz == null)
            {
                return NotFound($"Quiz with id: {id} not found!");
            }

            return Ok(quiz);
        }
    }
}