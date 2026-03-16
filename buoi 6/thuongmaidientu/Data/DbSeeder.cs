using Microsoft.AspNetCore.Identity;
using thuongmaidientu.Models;

namespace thuongmaidientu.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // Seed Roles
            string[] roleNames = { "Admin", "Member" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Seed Admin User
            var adminEmail = "admin@example.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FullName = "System Admin",
                    Address = "Admin HQ",
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(adminUser, "Admin@123");
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }

            // Seed Member User
            var memberEmail = "member@example.com";
            var memberUser = await userManager.FindByEmailAsync(memberEmail);
            if (memberUser == null)
            {
                memberUser = new ApplicationUser
                {
                    UserName = memberEmail,
                    Email = memberEmail,
                    FullName = "Standard Member",
                    Address = "Member House",
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(memberUser, "Member@123");
                await userManager.AddToRoleAsync(memberUser, "Member");
            }
        }
    }
}
