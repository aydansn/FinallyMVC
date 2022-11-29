using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FinallyMVC.Domain.Models.DataContexts
{
    public static class AppDbContextSeedData
    {
        public static IApplicationBuilder SeedMembership(this IApplicationBuilder app)
        {
            const string adminEmail = "aydansn@code.edu.az";
            const string adminUserName = "aydansn";
            const string adminPassword = "123";
            const string roleName = "sa";

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                db.Database.Migrate();

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<FinallymvcUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<FinallymvcRole>>();

                var role = roleManager.FindByNameAsync(roleName).Result;

                if (role == null)
                {
                    role = new FinallymvcRole
                    {
                        Name = roleName
                    };

                    roleManager.CreateAsync(role).Wait();
                }

                var user = userManager.FindByEmailAsync(adminEmail).Result;

                if (user == null)
                {
                    user = new FinallymvcUser
                    {
                        Email = adminEmail,
                        UserName = adminUserName,
                        EmailConfirmed = true
                    };

                    userManager.CreateAsync(user, adminPassword).Wait();
                }

                if (userManager.IsInRoleAsync(user, roleName).Result == false)
                {
                    userManager.AddToRoleAsync(user, roleName).Wait();
                }
            }

            return app;
        }
    }
}
