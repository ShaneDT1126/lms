using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api/v1/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();

            if (students == null)
            {
                return NotFound();
            }

            return Ok(students);
        }

        [HttpGet("{studentId}")]
        public ActionResult GetStudentById(int studentId)
        {
            var student = _studentService.GetStudentById(studentId);

            if (student == null)
            {
                return NotFound($"Student with id: {studentId} not found");
            }

            return Ok(student);
        }

        [HttpGet("enrollments/{studentId}")]
        public ActionResult GetAllEnrollmentsByStudent(int studentId)
        {
            var enrollments = _studentService.GetAllEnrollmentsByStudent(studentId);

            if (enrollments == null)
            {
                return NotFound("No enrollments found!");
            }

            return Ok(enrollments);
        }

        [HttpGet("forumcomments/{studentId}")]
        public ActionResult GetAllForumCommentsByStudent(int studentId)
        {
            var forumComments = _studentService.GetAllForumCommentByStudent(studentId);

            if (forumComments == null)
            {
                return NotFound($"Student Id: {studentId} has no comments found!");
            }

            return Ok(forumComments);
        }

        [HttpGet("quizmanagements/{studentId}")]
        public ActionResult GetAllQuizManagementByStudent(int studentId)
        {
            var quizManagement = _studentService.GetAllQuizManagementByStudent(studentId);

            if (quizManagement == null)
            {
                return NotFound($"Quiz Stat by student Id: {studentId} not found!");
            }

            return Ok(quizManagement);
        }
    }
}
