namespace Triolingo.Domain
{
    public class Language : BaseDomainModel
    {
        public int LanguageId { get; set; } //PK
        public string? Name { get; set; }
        public int UserId { get; set; } //FK from User entity
        public int LessonId { get; set; } //FK from Lesson entity
    }
}
