using Microsoft.AspNetCore.Identity;

namespace Triolingo.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class TriolingoUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int UserProgress { get; set; }
        public int UserScore { get; set; }
    }
}
