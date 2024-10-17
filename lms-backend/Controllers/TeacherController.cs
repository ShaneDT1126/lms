using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api/v1")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet("/teachers")]
        public ActionResult GetAllTeachers()
        {
            var teachers = _service.GetAllTeachers();

            if (teachers == null)
            {
                return NotFound("No Teachers Found!");
            }

            return Ok(teachers);
        }

        [HttpGet("/teacher/{id}")]
        public ActionResult GetTeacherById(int id)
        {

        }
    }
}
