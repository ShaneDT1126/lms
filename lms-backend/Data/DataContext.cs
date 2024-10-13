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
            modelBuilder.Entity<>()
        }

    }
}
