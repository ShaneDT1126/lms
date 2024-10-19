using lms_backend.DTOs;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;

namespace lms_backend.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _repository;

        public EnrollmentService(IEnrollmentRepository repository)
        {
            _repository = repository;
        }


        public ICollection<EnrollmentDto> GetAllEnrollmentsByCourse(int courseId)
        {
            var enrollments = _repository.GetAllEnrollmentsByCourse(courseId);

            if (enrollments == null || !enrollments.Any())
            {
                return null;
            }

            var enrollmentDto = enrollments.Select(e => new EnrollmentDto
            {
                StudentId = e.StudentId,
                CourseId = e.CourseId,
                Student = e.Student,
                Course = e.Course
            }).ToList();

            return enrollmentDto;
        }

        public ICollection<EnrollmentDto> GetALlEnrollmentsByStudent(int studentId)
        {
            var enrollments = _repository.GetAllEnrollmentsByStudent(studentId);
            if (enrollments == null || !enrollments.Any())
            {
                return null;
            }

            var enrollmentDto = enrollments.Select(s => new EnrollmentDto
            {
                StudentId = s.StudentId,
                CourseId = s.CourseId,
                Student = s.Student,
                Course = s.Course
            }).ToList();

            return enrollmentDto;
        }
    }
}
