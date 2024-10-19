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

        [HttpGet("courses/{courseId}")]
        public ActionResult GetAllLessonByCourse(int courseId) { 
            var lessons = _lessonService.GetAllLessonByCourse(courseId);

            if (lessons == null)
            {
                return NotFound($"No Lessons Found in Course: {courseId}!");
            }

            return Ok(lessons);
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
    }
}
