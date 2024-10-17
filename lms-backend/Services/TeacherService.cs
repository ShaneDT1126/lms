using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
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

            if (teachers == null)
            {
                return null;
            }

            var teachersDto = teachers.Select(t => new TeacherDto
            {
                Id = t.Id,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Age = t.Age,
                Birthdate = t.Birthdate,
                Username = t.Username,
                Password = t.Password

            }).ToList();

            return teachersDto;
        }

        public Models.Teacher? GetTeacherById(int id)
        {
            var teacher = GetTeacherById(id);

            if (teacher == null)
            {
                return null;
            }

            return teacher;
        }
    }
}
