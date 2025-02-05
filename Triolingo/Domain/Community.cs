using Azure.Core;

namespace Triolingo.Domain
{
    public class Community : BaseDomainModel
    {
        public int CommunityId { get; set; }//PK
        public string? ConversationTopic { get; set; }
        public string? Conversation {  get; set; }
        public int LanguageId { get; set; }//FK from Language entity
        public int UserId { get; set; }//Fk from User entity
        public DateOnly PostedOn { get; set; }
    }
}
