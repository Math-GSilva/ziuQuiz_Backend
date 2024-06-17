using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra
{
    public class QuizDbContext : DbContext
    {
        private IConfiguration configuration;
        public DbSet<Quiz> Quizes { get; set; }

        public QuizDbContext(IConfiguration configuration, DbContextOptions<QuizDbContext> options) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = configuration.GetConnectionString("SqlServer");
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
