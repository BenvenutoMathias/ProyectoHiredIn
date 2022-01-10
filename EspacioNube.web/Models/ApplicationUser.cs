using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /* public string Gender { get; set; } */
        public byte[] Photo { get; set; }

    }