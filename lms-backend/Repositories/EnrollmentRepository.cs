using lms_backend.Data;
using lms_backend.Models;
using lms_backend.RepositoryInterface;

namespace lms_backend.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly DataContext _dataContext;

        public EnrollmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<Enrollment> GetAllEnrollmentsByCourse(int courseId)
        {
            var course = _dataContext.Courses.FirstOrDefault(c => c.Id == courseId);

            if (course?.Enrollments == null)
            {
                return null;
            }

            var enrollments = course.Enrollments.ToList();

            return enrollments;
        }

        public ICollection<Enrollment> GetAllEnrollmentsByStudent(int studentId)
        {
            var student = _dataContext.Students.FirstOrDefault(s => s.Id == studentId);

            if (student?.Enrollments == null)
            {
                return null;
            }

            var enrollments = student.Enrollments.ToList();

            return enrollments;
        }
    }
}
