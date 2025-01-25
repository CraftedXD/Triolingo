namespace Triolingo.Domain
{
    public class Question : BaseDomainModel
    {
        public int QuestionId { get; set; }//PK
        public string? QuestionText { get; set; }
        public string? UserAnswer {  get; set; }
        public string? CorrectAnswer { get; set; }
        public int QuizId { get; set; }//FK from Quiz entity
    }
}
