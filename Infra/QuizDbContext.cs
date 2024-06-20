using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra
{
    public class QuizDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quiz>().ToTable("Quiz");
            modelBuilder.Entity<Category>().ToTable("Categoria");
            modelBuilder.Entity<Question>().ToTable("Questions");

            modelBuilder.Entity<Quiz>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Quiz>()
                .Property(q => q.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Quiz>()
                .Property(q => q.Nome)
                .IsRequired();

            modelBuilder.Entity<Quiz>()
                .HasOne(q => q.Category)
                .WithMany()
                .HasForeignKey(q => q.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Quiz>()
                .HasMany(q => q.Questions)
                .WithOne()
                .HasForeignKey(q => q.IdQuiz) // Apenas o ID do Quiz
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Category>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .Property(c => c.Nome)
                .IsRequired();

            modelBuilder.Entity<Question>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Question>()
                .Property(q => q.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Question>()
                .Property(q => q.Resposta)
                .IsRequired();

            modelBuilder.Entity<Question>()
                .Property(q => q.Alternativa1)
                .IsRequired();

            modelBuilder.Entity<Question>()
                .Property(q => q.Alternativa2)
                .IsRequired();

            modelBuilder.Entity<Question>()
                .Property(q => q.Alternativa3)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conn = _configuration.GetConnectionString("SqlServer");
                optionsBuilder.UseSqlServer(conn);
            }
        }
    }
}
