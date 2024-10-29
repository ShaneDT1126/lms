using lms_backend.DTOs;
using lms_backend.Interface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }


        public ICollection<TeacherDto> GetAllTeachers()
        {
            var teachers = _repository.GetAllTeachers();

            if (!teachers.Any())
            {
                return null;
            }

            var teachersDto = teachers.Select(t => new TeacherDto
            {
                Id = t.Id,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Age = t.Age,
                Birthdate = t.Birthdate

            }).ToList();

            return teachersDto;
        }

        public TeacherDto? GetTeacherById(int id)
        {
            var teacher = _repository.GetTeacherById(id);

            if (teacher == null)
            {
                return null;
            }

            var teacherDto = new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Age = teacher.Age,
                Birthdate = teacher.Birthdate,
                Email = teacher.Email
            };

            return teacherDto;
        }

        public ICollection<CourseDto>? GetAllCoursesByTeacher(int teacherId)
        {
            var courses = GetAllCoursesByTeacher(teacherId);

            if (courses == null || !courses.Any())
            {
                return null;
            }

            var coursesDto = courses.Select(c => new CourseDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Teacher = c.Teacher,
                CreatedAt = c.CreatedAt,
                Lessons = c.Lessons
            }).ToList();

            return coursesDto;
        }
    }
}
