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

            if (!courses.Any())
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

        public ICollection<LessonDto> GetAllLessonByCourse(int courseId)
        {
            var lessons = _courseRepository.GetAllLessonByCourse(courseId);

            if (lessons == null || !lessons.Any())
            {
                return null;
            }

            var lessonDto = lessons.Select(l => new LessonDto
            {
                Id = l.Id,
                Name = l.Name,
                Description = l.Description,
                CreatedAt = l.CreatedAt,
                Content = l.Content
            }).ToList();

            return lessonDto;
        }

        public ICollection<EnrollmentDto> GetAllEnrollmentsByCourse(int courseId)
        {
            var enrollments = _courseRepository.GetAllEnrollmentsByCourse(courseId);

            if (enrollments == null || !enrollments.Any())
            {
                return null;
            }

            var enrollmentDto = enrollments.Select(e => new EnrollmentDto
            {
                StudentId = e.StudentId,
                CourseId = e.CourseId,
                Course = e.Course,
                Student = e.Student
            }).ToList();

            return enrollmentDto;
        }
    }
}
