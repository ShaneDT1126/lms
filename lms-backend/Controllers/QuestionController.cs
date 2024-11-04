using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/questions")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public ActionResult GetAllQuestions()
        {
            var questions = _questionService.GetAllQuestions();

            if (questions == null)
            {
                return NotFound("No questions found!");
            }

            return Ok(questions);
        }
    }
}
