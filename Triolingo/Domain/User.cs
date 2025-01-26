namespace Triolingo.Domain
{
    public class User : BaseDomainModel
    {
        public int UserId { get; set; }
        public string? Name {  get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public int UserProgress { get; set; }
    }
}
