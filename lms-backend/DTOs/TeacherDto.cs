using lms_backend.DTOs.BaseDto;
using lms_backend.Models;

namespace lms_backend.DTOs
{
    public class TeacherDto : BaseUserDto
    {
        public List<Course> Courses { get; set; } = [];
        public List<Post> Posts { get; set; } = [];
    }
}
