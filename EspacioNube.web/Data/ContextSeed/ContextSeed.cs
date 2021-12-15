using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace EspacioNube.web.Data
{   
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            await roleManager.CreateAsync(new IdentityRole("UserDefault"));
            await roleManager.CreateAsync(new IdentityRole("Empresa"));
        }

    }
}