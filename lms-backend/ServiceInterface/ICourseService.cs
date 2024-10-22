using lms_backend.DTOs;

namespace lms_backend.ServiceInterface
{
    public interface ICourseService
    {
        ICollection<CourseDto> GetAllCourses();
        CourseDto GetCourseById(int id);
        ICollection<LessonDto> GetAllLessonByCourse(int courseId);
        ICollection<EnrollmentDto> GetAllEnrollmentsByCourse(int courseId);
    }
}
