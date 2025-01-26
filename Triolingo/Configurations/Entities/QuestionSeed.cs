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
                },
                new Question
                {
                    QuestionId = 11,
                    QuestionText = "What is this Character? 一",
                    UserAnswer = "",
                    CorrectAnswer = "yi",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 12,
                    QuestionText = "What is this Character? 二",
                    UserAnswer = "",
                    CorrectAnswer = "er",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 13,
                    QuestionText = "What is this Character? 三",
                    UserAnswer = "",
                    CorrectAnswer = "san",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 14,
                    QuestionText = "What is this Character? 四",
                    UserAnswer = "",
                    CorrectAnswer = "si",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 15,
                    QuestionText = "What is this Character? 五",
                    UserAnswer = "",
                    CorrectAnswer = "wu",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 16,
                    QuestionText = "What is this Character? 六",
                    UserAnswer = "",
                    CorrectAnswer = "liu",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 17,
                    QuestionText = "What is this Character? 七",
                    UserAnswer = "",
                    CorrectAnswer = "qi",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 18,
                    QuestionText = "What is this Character? 八",
                    UserAnswer = "",
                    CorrectAnswer = "ba",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 19,
                    QuestionText = "What is this Character? 九",
                    UserAnswer = "",
                    CorrectAnswer = "jiu",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Question
                {
                    QuestionId = 20,
                    QuestionText = "What is this Character? 十",
                    UserAnswer = "",
                    CorrectAnswer = "shi",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
