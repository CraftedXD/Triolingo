using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Triolingo.Domain;

namespace Triolingo.Configurations.Entities
{
    public class QuizSeed : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData(
                new Quiz
                {
                    QuizId = 1,
                    QuizTitle = "Japanese Quiz 1",
                    LevelDifficultly = 1,
                    LessonId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    QuizId = 2,
                    QuizTitle = "Japanese Quiz 2",
                    LevelDifficultly = 2,
                    LessonId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
