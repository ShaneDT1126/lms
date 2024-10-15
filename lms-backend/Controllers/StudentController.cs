using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("/students")]
        public ActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();

            if (students == null)
            {
                return NotFound();
            }

            return Ok(students);
        }

        [HttpGet("/student/{studentId}")]
        public ActionResult GetStudentById(int studentId)
        {
            var student = _studentService.GetStudentById(studentId);

            if (student == null)
            {
                return NotFound($"Student with id: {studentId} not found");
            }

            return Ok(student);
        }
    }
}
