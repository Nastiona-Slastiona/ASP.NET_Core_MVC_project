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

           /* if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new List<Category>
                    {
                        new Category{CategoryName = "Inspiration"},
                        new Category{CategoryName = "Comedy"},
                        new Category{CategoryName = "Music"},
                        new Category{CategoryName = "Horror"}
                    });
                await context.SaveChangesAsync();
            }

            if (!context.Moovies.Any())
            {
                context.Moovies.AddRange(
                    new List<Moovie>
                    {
                          new Moovie{ID = 1, Name = "В погоне за счастьем", Description = "Moovie about men's life.", CategoryID = 1, Time = 90, Image = "First.jpg" },
                          new Moovie{ID = 1, Name = "Всегда говори Да", Description = "Moovie about men's life.", CategoryID = 2, Time = 120, Image = "Second.jpg" },
                          new Moovie{ID = 1, Name = "La-La-Land", Description = "Moovie about men's life.", CategoryID = 3, Time = 115, Image = "3.jpg" },
                          new Moovie{ID = 1, Name = "Оно", Description = "Moovie about men's life.", CategoryID = 4, Time = 113, Image = "4.jpg" },
                          new Moovie{ID = 1, Name = "Отпетые мошенницы", Description = "Moovie about men's life.", CategoryID = 2, Time = 120, Image = "5.jpg" }

                    });
                await context.SaveChangesAsync();
            }*/
        }
    }
}
