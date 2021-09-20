using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Data
{
    public class DBInitializer
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                await roleManager.CreateAsync(roleAdmin);
            }

            if (!context.Users.Any())
            {

                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "userName"
                };
                await userManager.CreateAsync(user, "password");

                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "password");

                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
        }
    }
}
