﻿using lms_backend.Data;
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
            var students = _context.Students.OrderBy(p => p.Id).ToList();

            if (students == null)
            {
                return null;
            }

            return students;
        }

        public Student? GetStudentById(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return null;
            }

            return student;
        }

        public ICollection<Enrollment> GetAllEnrollmentsByStudent(int studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);

            if (student == null)
            {
                return null;
            }

            var enrollments = student.Enrollments.ToList();

            if (enrollments == null || !enrollments.Any())
            {
                return null;
            }

            return enrollments;
        }
    }
}
