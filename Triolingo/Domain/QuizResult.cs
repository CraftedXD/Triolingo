namespace Triolingo.Domain
{
    public class QuizResult :BaseDomainModel
    {
        public int QuizResultId { get; set; }//PK
        public int Score { get; set; }
        public int QuizId { get; set; }//FK from Quiz entity
        public int UserId { get; set; }//FK from User entity
    }
}
