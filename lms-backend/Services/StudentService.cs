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

        public ICollection<StudentDto>? GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();

            if (!students.Any())
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
                Email = s.Email
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
                Id = student!.Id,
                FirstName = student!.FirstName,
                LastName = student!.LastName,
                Age = student!.Age,
                Birthdate = student!.Birthdate,
                Email = student!.Email
            };

            return studentDto;
        }

        public ICollection<EnrollmentDto>? GetAllEnrollmentsByStudent(int studentId)
        {
            var studentEnrollments = _studentRepository.GetAllEnrollmentsByStudent(studentId);

            if (studentEnrollments == null || !studentEnrollments.Any())
            {
                return null;
            }

            var enrollmentDto = studentEnrollments.Select(e => new EnrollmentDto
            {
                StudentId = e.StudentId,
                CourseId = e.CourseId,
                Student = e.Student,
                Course = e.Course
            }).ToList();

            return enrollmentDto;
        }
    }
}
