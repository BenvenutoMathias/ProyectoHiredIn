using Microsoft.AspNetCore.Identity;

namespace DataAccess.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[]? Photo { get; set; }
    }
}
