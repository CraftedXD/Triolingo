namespace Triolingo.Domain
{
    public class Scoreboard : BaseDomainModel
    {
        public int ScoreboardId { get; set; }//PK
        public int TotalScore {  get; set; }
        public string? UserId { get; set; }//Fk from User entity
        public int LanguageId { get; set; }//FK from Language entity
    }
}
