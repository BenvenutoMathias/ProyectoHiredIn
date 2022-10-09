using Microsoft.AspNetCore.Identity;
using DataAccess.Models;

namespace DataAccess.ContexSeed
{
    public enum Roles
    {
        SuperAdmin,
        UserDefault,
        Empresa,
    }
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.UserDefault.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Empresa.ToString()));
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
                PhoneNumberConfirmed = true
            };
            //Seed Default Enterprise
            var defaultEnterprise = new ApplicationUser
            {
                UserName = "Centum",
                Email = "mathias@centum.com.ar",
                FirstName = "Matias",
                LastName = "Gabriel",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "2397");
                    await userManager.AddToRoleAsync(defaultUser, Roles.SuperAdmin.ToString());
                }
            }

            if (userManager.Users.All(u => u.Id != defaultEnterprise.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultEnterprise.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultEnterprise, "2397");
                    await userManager.AddToRoleAsync(defaultEnterprise, Roles.Empresa.ToString());
                }
            }
        }
    }
}