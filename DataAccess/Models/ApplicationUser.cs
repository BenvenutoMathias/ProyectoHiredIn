using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public byte[]? Photo { get; set; }
    }
}
