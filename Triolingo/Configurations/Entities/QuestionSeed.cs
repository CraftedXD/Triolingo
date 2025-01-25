using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Triolingo.Domain;

namespace Triolingo.Configurations.Entities
{
    public class QuestionSeed : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                new Question
                {
                    QuestionId = 1,
                    QuestionText = "What is this hiragana? あ",
                    UserAnswer = "",
                    CorrectAnswer = "a",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 2  ,
                    QuestionText = "What is this hiragana? い",
                    UserAnswer = "",
                    CorrectAnswer = "i",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 3,
                    QuestionText = "What is this hiragana? う",
                    UserAnswer = "",
                    CorrectAnswer = "u",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 4,
                    QuestionText = "What is this hiragana? え",
                    UserAnswer = "",
                    CorrectAnswer = "e",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 5,
                    QuestionText = "What is this hiragana? お",
                    UserAnswer = "",
                    CorrectAnswer = "o",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 6,
                    QuestionText = "What is this hiragana? か",
                    UserAnswer = "",
                    CorrectAnswer = "ka",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 7,
                    QuestionText = "What is this hiragana? き",
                    UserAnswer = "",
                    CorrectAnswer = "ki",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 8,
                    QuestionText = "What is this hiragana? く",
                    UserAnswer = "",
                    CorrectAnswer = "ku",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 9,
                    QuestionText = "What is this hiragana? け",
                    UserAnswer = "",
                    CorrectAnswer = "ke",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 10,
                    QuestionText = "What is this hiragana? こ",
                    UserAnswer = "",
                    CorrectAnswer = "ko",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
