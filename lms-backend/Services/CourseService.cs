using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository repository)
        {
            _courseRepository = repository;
        }


        public ICollection<CourseDto> GetAllCourses()
        {
            var courses = _courseRepository.GetAllCourses();

            if (courses == null)
            {
                return null;
            }

            var coursesDto = courses.Select(c => new CourseDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                CreatedAt = c.CreatedAt,
                Teacher = c.Teacher

            }).ToList();

            return coursesDto;
        }

        public CourseDto GetCourseById(int id)
        {
            var course = _courseRepository.GetCourseById(id);

            if (course == null)
            {
                return null;
            }

            var courseDto = new CourseDto
            {
                Name = course.Name,
                Description = course.Description,
                CreatedAt = course.CreatedAt,
                Teacher = course.Teacher
            };

            return courseDto;
        }
    }
}
