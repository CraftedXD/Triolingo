namespace Triolingo.Domain
{
    public class Lesson : BaseDomainModel
    {
        public int LessonId { get; set; }//PK
        public string? LessonName { get; set; }
        public string? LessonContent { get; set; }
        public int LessonOrder { get; set; }
        public int LanguageId { get; set; } //FK from Language entity
    }
}
