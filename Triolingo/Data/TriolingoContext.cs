using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Triolingo.Configurations.Entities;
using Triolingo.Data;

namespace Triolingo.Data
{
    public class TriolingoContext(DbContextOptions<TriolingoContext> options) : IdentityDbContext<TriolingoUser>(options)
    {

        public DbSet<Triolingo.Domain.User> User { get; set; } = default!;
        public DbSet<Triolingo.Domain.Language> Language { get; set; } = default!;
        public DbSet<Triolingo.Domain.Lesson> Lesson { get; set; } = default!;
        public DbSet<Triolingo.Domain.Quiz> Quiz { get; set; } = default!;
        public DbSet<Triolingo.Domain.Question> Question { get; set; } = default!;
        public DbSet<Triolingo.Domain.QuizResult> QuizResult { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());

            builder.ApplyConfiguration(new UserRoleSeed());

            builder.ApplyConfiguration(new UserSeed());

            builder.ApplyConfiguration(new LanguageSeed());

            builder.ApplyConfiguration(new LessonSeed());

            builder.ApplyConfiguration(new QuizSeed());

            builder.ApplyConfiguration(new QuestionSeed());
        }
    }
}
