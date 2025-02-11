﻿using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Services.DataInitializer
{
    public class UserDataInitializer :DataInitializer, IDataInitializer
    {
        private readonly UserManager<User> userManager;

        public UserDataInitializer(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public override int Order => 2;

        public void InitializeData()
        {
            if (!userManager.Users.AsNoTracking().Any(p => p.UserName == "Admin"))
            {
                var user = new User
                {
                    //Age = 33,
                    FirstName = "مدیر",
                    LastName = "سایت",
                    NationalNumber = "3490318825",
                    PersonalCode = "1234567890",
                    Gender = GenderType.Male,
                    Type = UserType.Admin,
                    IsActive = true,
                    LastLoginDate = System.DateTimeOffset.Now,
                    IsDeleted = false,
                    UserName = "admin",
                    Email = "admin@site.com",
                    EmailConfirmed = true
                };
                var result = userManager.CreateAsync(user, "123456A1!").GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    result = userManager.AddToRolesAsync(user, new string[] { "Admin" }).GetAwaiter().GetResult();
                }
            }
        }
    }
}