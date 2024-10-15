using lms_backend.DTOs;
using lms_backend.Interface;
using lms_backend.Models;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ICollection<StudentDto> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();

            if (students == null || !students.Any())
            {
                return null;
            }

            var studentsDto = students.Select(s => new StudentDto
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Birthdate = s.Birthdate,
                Email = s.Email,
                Username = s.Username,
                Password = s.Password
            }).ToList();

            return studentsDto;
        }
    }
}
