using lms_backend.Data;
using lms_backend.Interface;
using lms_backend.Models;

namespace lms_backend.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context) 
        {
            _context = context;
        }


        public ICollection<Student> GetAllStudents()
        {
            return _context.Students.OrderBy(p => p.Id).ToList();
        }
    }
}
