using Lab20.P01_StudentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab20.P01_StudentSystem.Data
{
    public class StudentContext : DbContext
    {
        DbSet<Student> Students => Set<Student>();
        DbSet<Course> Courses => Set<Course>();
        DbSet<Resource> Resources => Set<Resource>();
        DbSet<Homework> Homeworks => Set<Homework>();
        DbSet<StudentCourse> StudentCourses => Set<StudentCourse>();

        public StudentContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=localhost;Database=studentDatabase;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<StudentCourse>(
                j => j
                    .HasOne(sc => sc.Course)
                    .WithMany(c => c.StudentsEnrolled)
                    .HasForeignKey(sc => sc.CourseId),

                j => j
                    .HasOne(sc => sc.Student)
                    .WithMany(s => s.RegisteredOn)
                    .HasForeignKey(sc => sc.StudentId),

                j =>
                    {
                        j.HasKey(sc => new { sc.CourseId, sc.StudentId });
                        j.ToTable("StudentCourses");
                    }
                );

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var students = new List<Student>
            {
                new Student {Id = 1, Name = "John Doe", Phone = "1234567890", Birthday = new DateOnly(1990, 1, 1) },
                new Student {Id = 2, Name = "Jane Doe", Phone = "9876543210", Birthday = new DateOnly(1995, 5, 5) },
            };

            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "Mathematics", Description = "Introduction to Mathematics", StartDate = DateOnly.FromDateTime(DateTime.Now),
                    EndDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(3), Price = 100.0f
                },
                new Course
                {
                    Id = 2,
                    Name = "Computer Science", Description = "Fundamentals of Programming", StartDate = DateOnly.FromDateTime(DateTime.Now),
                    EndDate = DateOnly.FromDateTime(DateTime.Now).AddMonths(4), Price = 150.0f
                },
            };

            var resources = new List<Resource>
            {
                new Resource {Id = 1, Name = "Video Lecture 1", Url = "https://example.com/lecture1", ResourceType = ResourceType.Video, CourseId = courses[0].Id },
                new Resource {Id = 2, Name = "Presentation Slide", Url = "https://example.com/presentation", ResourceType = ResourceType.Presentation, CourseId = courses[1].Id },
            };

            var homeworkSubmissions = new List<Homework>
            {
                new Homework {Id = 1, Content = "Homework content 1", ContentType = ContentType.Application, SubmissionTime = DateTime.Now, StudentId = students[0].Id, CourseId = courses[0].Id },
                new Homework {Id = 2, Content = "Homework content 2", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now,StudentId = students[1].Id, CourseId = courses[1].Id  },
            };
            modelBuilder.Entity<Course>().HasData(courses);

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<StudentCourse>().HasData(
                new List<StudentCourse>
                {
                    new StudentCourse {StudentId = students[0].Id, CourseId = courses[0].Id},
                    new StudentCourse {StudentId = students[0].Id, CourseId = courses[1].Id},
                    new StudentCourse {StudentId = students[1].Id, CourseId = courses[1].Id},
                }
            );
            modelBuilder.Entity<Resource>().HasData(resources);

            modelBuilder.Entity<Homework>().HasData(homeworkSubmissions);
        }
    }
}

