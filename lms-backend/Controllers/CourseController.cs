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

        [HttpGet("enrollments/{courseId}")]
        public ActionResult GetAllEnrollmentsByCourse(int courseId)
        {
            var enrollments = _courseService.GetAllEnrollmentsByCourse(courseId);

            if (enrollments == null)
            {
                return NotFound($"No enrolled students found in CourseId: {courseId}!");
            }

            return Ok(enrollments);
        }

        [HttpGet("lessons/{courseId}")]
        public ActionResult GetAllLessonsByCourse(int courseId)
        {
            var lessons = _courseService.GetAllLessonByCourse(courseId);

            if (lessons == null)
            {
                return NotFound($"No lessons found in CourseId: {courseId}");
            }

            return Ok(lessons);
        }


    }
}
