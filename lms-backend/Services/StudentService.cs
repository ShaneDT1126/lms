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

        public StudentDto? GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentById(id);

            if (student == null)
            {
                return null;
            }

            var studentDto = new StudentDto
            {
                Id = student.Id,
                FirstName = student!.FirstName,
                LastName = student!.LastName,
                Age = student!.Age,
                Birthdate = student!.Birthdate,
                Email = student!.Email,
                Username = student!.Username,
                Password = student!.Password
            };

            return studentDto;
        }
    }
}
