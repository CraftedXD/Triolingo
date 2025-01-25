namespace Triolingo.Domain
{
    public class Quiz : BaseDomainModel
    {
        public int QuizId { get; set; }//PK
        public  string? QuizTitle { get; set; }
        public int LevelDifficultly { get; set; }
        public int LessonId { get; set; }//FK from Lesson entity
    }
}
