
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

    public static class SeedEmployees
    {
        public async static Task<IdentityResult> SeedAllEmployees(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "michelle@example.com",
                Email = "michelle@example.com",
                PhoneNumber = "214-059-8367",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Michelle",
                LastName = "Banks",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78705",

            },
            Password = "jVb0Z6",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "toddy@aool.com",
                Email = "toddy@aool.com",
                PhoneNumber = "678-014-2359",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Todd",
                LastName = "Jacobs",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78712",

            },
            Password = "1PnrBV",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "elowe@netscrape.net",
                Email = "elowe@netscrape.net",
                PhoneNumber = "486-371-0295",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Ernest",
                LastName = "Lowe",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78786",

            },
            Password = "v3n5AV",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "mclarence@aool.com",
                Email = "mclarence@aool.com",
                PhoneNumber = "840-175-9236",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Clarence",
                LastName = "Martin",
                StreetAddress = "50883 Heath Park",
                City = "Eagle Pass",
                State = "TX",
                ZipCode = "78852",

            },
            Password = "zBLq3S",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "nelson.Kelly@aool.com",
                Email = "nelson.Kelly@aool.com",
                PhoneNumber = "931-567-4802",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Kelly",
                LastName = "Nelson",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78329",

            },
            Password = "FSb8rA",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "megrhodes@freezing.co.uk",
                Email = "megrhodes@freezing.co.uk",
                PhoneNumber = "259-163-0748",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Megan",
                LastName = "Rhodes",
                StreetAddress = "50883 Heath Park",
                City = "Georgetown",
                State = "TX",
                ZipCode = "78628",

            },
            Password = "1xVfHp",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "sheff44@ggmail.com",
                Email = "sheff44@ggmail.com",
                PhoneNumber = "306-712-4895",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Martin",
                LastName = "Sheffield",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78705",

            },
            Password = "4XKLsd",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "peterstump@hootmail.com",
                Email = "peterstump@hootmail.com",
                PhoneNumber = "976-841-2350",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Peter",
                LastName = "Stump",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78704",

            },
            Password = "1XdmSV",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "yhuik9.Taylor@aool.com",
                Email = "yhuik9.Taylor@aool.com",
                PhoneNumber = "935-870-4162",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Rachel",
                LastName = "Taylor",
                StreetAddress = "50883 Heath Park",
                City = "College Station",
                State = "TX",
                ZipCode = "77840",

            },
            Password = "9yhFS3",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "tuck33@ggmail.com",
                Email = "tuck33@ggmail.com",
                PhoneNumber = "795-163-2408",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Clent",
                LastName = "Tucker",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78756",

            },
            Password = "I6BgsS",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "taylordjay@aool.com",
                Email = "taylordjay@aool.com",
                PhoneNumber = "674-150-2983",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Allison",
                LastName = "Taylor",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78746",

            },
            Password = "Vjb1wI",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "jojoe@ggmail.com",
                Email = "jojoe@ggmail.com",
                PhoneNumber = "291-735-0648",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Joe",
                LastName = "Nguyen",
                StreetAddress = "50883 Heath Park",
                City = "Austin",
                State = "TX",
                ZipCode = "78756",

            },
            Password = "xI8Brg",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "hicks43@ggmail.com",
                Email = "hicks43@ggmail.com",
                PhoneNumber = "506-487-3192",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Anthony",
                LastName = "Hicks",
                StreetAddress = "50883 Heath Park",
                City = "Liberty",
                State = "TX",
                ZipCode = "77575",

            },
            Password = "s33WOz",
            RoleName = "Employee"
        });
        AllUsers.Add(new AddUserModel()
        {
            User = new AppUser()
            {
                // populate the user properties that are from the
                //IdentityUser base class
                UserName = "orielly@foxnets.com",
                Email = "orielly@foxnets.com",
                PhoneNumber = "476-251-8093",

                // Add additional fields that you created on the AppUser class
                //FirstName is included as an example
                FirstName = "Bill",
                LastName = "O'Reilly",
                StreetAddress = "50883 Heath Park",
                City = "San Antonio",
                State = "TX",
                ZipCode = "78203",

            },
            Password = "pS2OJh",
            RoleName = "Employee"
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
