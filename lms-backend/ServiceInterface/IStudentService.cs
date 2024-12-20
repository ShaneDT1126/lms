﻿using lms_backend.DTOs;


namespace lms_backend.ServiceInterface
{
    public interface IStudentService
    {
        ICollection<StudentDto> GetAllStudents();
        StudentDto? GetStudentById(int id);
        ICollection<EnrollmentDto> GetAllEnrollmentsByStudent(int studentId);
        ICollection<ForumCommentDto> GetAllForumCommentByStudent(int studentId);
        ICollection<QuizManagementDto> GetAllQuizManagementByStudent(int studentId);
        ICollection<LessonProgressionDto>? GetAllLessonProgressionByStudent(int studentId);
    }
}
