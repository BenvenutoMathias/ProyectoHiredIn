using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace EspacioNube.web.Data
{   
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            await roleManager.CreateAsync(new IdentityRole("UserDefault"));
            await roleManager.CreateAsync(new IdentityRole("Empresa"));
        }

        
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
{
    //Seed Default User
    var defaultUser = new ApplicationUser 
    { 
        UserName = "superadmin", 
        Email = "mathiasdvt7@gmail.com",
        FirstName = "Mathias",
        LastName = "Benvenuto",
        EmailConfirmed = true, 
        PhoneNumberConfirmed = true, 
    };
    if (userManager.Users.All(u => u.Id != defaultUser.Id))
    {
        var user = await userManager.FindByEmailAsync(defaultUser.Email);
        
        if(user==null)
        {
            await userManager.CreateAsync(defaultUser, "Contraseña23!");
            await userManager.AddToRoleAsync(defaultUser, "SuperAdmin");
           /*  await userManager.AddToRoleAsync(defaultUser, "Empresa");
            await userManager.AddToRoleAsync(defaultUser, "UserDefault"); */
            
        }
        
    }
}
        

    }
}