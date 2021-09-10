using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Constants;

namespace WebAPI.Contexts
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Constants.Authorization.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Constants.Authorization.Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Constants.Authorization.Roles.User.ToString()));

            //Seed Default User
            var defaultUser = new ApplicationUser { UserName = Constants.Authorization.default_username, Email = Constants.Authorization.default_email, EmailConfirmed = true, PhoneNumberConfirmed = true };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, Constants.Authorization.default_password);
                await userManager.AddToRoleAsync(defaultUser, Constants.Authorization.default_role.ToString());
            }
        }
    }
}
