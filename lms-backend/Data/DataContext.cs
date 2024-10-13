using lms_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace lms_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; } //many-to-many of student and course
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonProgression> LessonsProgression { get; set; } // many-to-many of student and lessons
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<QuizManagement> QuizManagement { get; set; } // many-to-many of student and quiz
        public DbSet<Question> Question { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<ForumComment> ForumComments { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // setting up many-to-many relationship

            // Student - Course
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.CourseId });
            modelBuilder.Entity<Enrollment>()
                .HasOne(s => s.Student)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<Enrollment>()
                .HasOne(c => c.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(c => c.CourseId);

            // Student - Lesson
            modelBuilder.Entity<LessonProgression>()
                .HasKey(lp => new { lp.StudentId, lp.LessonId });
            modelBuilder.Entity<LessonProgression>()
                .HasOne(s => s.Student)
                .WithMany(lp => lp.LessonProgressions)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<LessonProgression>()
                .HasOne(l => l.Lesson)
                .WithMany(lp => lp.LessonProgressions)
                .HasForeignKey(l => l.LessonId);

            // Student - Quiz
            modelBuilder.Entity<QuizManagement>()
                .HasKey(qm => new { qm.StudentId, qm.QuizId});
            modelBuilder.Entity<QuizManagement>()
                .HasOne(s => s.Student)
                .WithMany(qm => qm.QuizManagement)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<QuizManagement>()
                .HasOne(q => q.Quiz)
                .WithMany(qm => qm.QuizManagements)
                .HasForeignKey(q => q.QuizId);
        }

    }
}
