﻿using lms_backend.Models;

namespace lms_backend.RepositoryInterface
{
    public interface ILessonRepository
    {
        Lesson GetLessonById(int id);
        ICollection<Lesson>? GetAllLessons();
        ICollection<LessonProgression>? GetAllLessonProgressionsByLesson(int lessonId);
    }
}
