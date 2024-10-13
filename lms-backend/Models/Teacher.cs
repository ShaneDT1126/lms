using lms_backend.Models.Base;

namespace lms_backend.Models
{
    public class Teacher : User
    {
        public List<Course> Courses { get; set; } = [];
        public List<Post> Posts { get; set; } = [];


    }
}
