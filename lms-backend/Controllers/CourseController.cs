using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api/v1/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public ActionResult GetAllCourses()
        {
            var courses = _courseService.GetAllCourses();

            if (courses == null)
            {
                return NotFound("No Courses Available!");
            }

            return Ok(courses);
        }

        [HttpGet("{courseId}")]
        public ActionResult GetCourse(int courseId)
        {
            var course = _courseService.GetCourseById(courseId);

            if (course == null)
            {
                return NotFound($"Course with an id: {courseId} not found!");
            }

            return Ok(course);
        }


    }
}
