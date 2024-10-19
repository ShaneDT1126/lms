using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/enrollments")]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet("courses/{courseId}")]
        public ActionResult GetAllEnrollmentsByCourse(int courseId)
        {
            var enrollments = _enrollmentService.GetAllEnrollmentsByCourse(courseId);

            if (enrollments == null)
            {
                return NotFound($"The course id: {courseId} has no enrolled student!");
            }

            return Ok(enrollments);
        }

        [HttpGet("students/{studentId}")]
        public ActionResult GetAllEnrollmentsByStudent(int studentId)
        {
            var enrollments = _enrollmentService.GetALlEnrollmentsByStudent(studentId);

            if (enrollments == null)
            {
                return NotFound($"The student id: {studentId} has no enrolled course!");
            }

            return Ok(enrollments);
        }
    }
}
