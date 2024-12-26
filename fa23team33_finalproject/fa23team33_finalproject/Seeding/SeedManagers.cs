
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using fa23team33_finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa23team33_finalproject.Seeding
{

    public static class SeedManagers
    {
        public async static Task<IdentityResult> SeedAllManagers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the
                //IdentityUser base class
                UserName = "ra@aoo.com",
                Email = "ra@aoo.com",
                PhoneNumber = "648-359-1270",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Allen",
                LastName = "Rogers",
                StreetAddress = "80686 Ryan Terrace",
                City = "Austin",
                State = "TX",
                ZipCode = "78704",

            },
            Password = "3wCynC",
            RoleName = "Manager"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the
                //IdentityUser base class
                UserName = "captain@enterprise.net",
                Email = "captain@enterprise.net",
                PhoneNumber = "170-936-2584",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Jean Luc",
                LastName = "Picard",
                StreetAddress = "97327 Express Avenue",
                City = "College Station",
                State = "TX",
                ZipCode = "77840",

            },
            Password = "Pbon0r",
            RoleName = "Manager"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the
                //IdentityUser base class
                UserName = "slayer@onegirl.net",
                Email = "slayer@onegirl.net",
                PhoneNumber = "591-682-4037",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Buffy",
                LastName = "Summers",
                StreetAddress = "1 Arrowood Road",
                City = "Austin",
                State = "TX",
                ZipCode = "78756",

            },
            Password = "jW5fPP",
            RoleName = "Manager"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the
                //IdentityUser base class
                UserName = "liz@ggmail.com",
                Email = "liz@ggmail.com",
                PhoneNumber = "806-349-1725",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Elizabeth",
                LastName = "Markham",
                StreetAddress = "5035 Dayton Court",
                City = "Austin",
                State = "TX",
                ZipCode = "78746",

            },
            Password = "0QyilL",
            RoleName = "Manager"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                //populate the user properties that are from the
                //IdentityUser base class
                UserName = "twin@deservedbetter.com",
                Email = "twin@deservedbetter.com",
                PhoneNumber = "508-914-2376",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Fred",
                LastName = "Weasley",
                StreetAddress = "90461 Evergreen Place",
                City = "Austin",
                State = "TX",
                ZipCode = "78756",

            },
            Password = "atLm6W",
            RoleName = "Manager"
        });
            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    // Took Utilities.AddUser from Relational Data Demo -> this is "Utilities/AddUser.cs"
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;

        }
    }
}
