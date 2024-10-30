using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/lessons")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("{id}")]
        public ActionResult GetLessonById(int id)
        {
            var lesson = _lessonService.GetLessonById(id);

            if (lesson == null)
            {
                return NotFound($"Lesson with id: {id} not found!");
            }

            return Ok(lesson);
        }
        [HttpGet]
        public ActionResult GetAllLessons()
        {
            var lessons = _lessonService.GetAllLessons();

            if (lessons == null)
            {
                return NotFound("No lessons found!");
            }

            return Ok(lessons);
        }

        public ActionResult GetAllLessonProgressionsByLesson(int lessonId)
        {
            var lessonProgressions = _lessonService.GetAllLessonProgressionsByLesson(lessonId);

            if (lessonProgressions == null)
            {
                return NotFound($"Lesson with an id {lessonId} don't have student lesson progressions!");
            }

            return Ok(lessonProgressions);
        }
    }
}
