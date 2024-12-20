using DotNetEnv;
using lms_backend.Data;
using lms_backend.Interface;
using lms_backend.Repositories;
using lms_backend.RepositoryInterface;
using lms_backend.ServiceInterface;
using lms_backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connection string using .env
Env.Load();
var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IForumRepository, ForumRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IForumCommentRepository, ForumCommentRepository>();
builder.Services.AddScoped<IQuizRepository, QuizRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<ITeacherService, TeacherService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IForumService, ForumService>();
builder.Services.AddTransient<ILessonService, LessonService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IForumCommentService, ForumCommentService>();
builder.Services.AddTransient<IQuizService, QuizService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database Setup
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
