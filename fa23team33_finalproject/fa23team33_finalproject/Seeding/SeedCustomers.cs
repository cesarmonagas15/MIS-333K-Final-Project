
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using fa23team33_finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace fa23team33_finalproject.Seeding
{

    public static class SeedCustomers
    {
        public async static Task<IdentityResult> SeedAllCustomers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "cbaker@example.com",
                    Email = "cbaker@example.com",
                    PhoneNumber = "152-275-7212",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    Birthday = DateTime.ParseExact("1945-08-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "1 David Park",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                },
                Password = "bookworm",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",
                    PhoneNumber = "596-211-5872",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Banks",
                    Birthday = DateTime.ParseExact("2000-11-18", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "10117 Swallow Road",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78712",
                },
                Password = "aclfest2017",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "franco@example.com",
                    Email = "franco@example.com",
                    PhoneNumber = "756-979-6344",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    Birthday = DateTime.ParseExact("2002-05-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "21344 Marcy Avenue",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78786",
                },
                Password = "aggies",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "wchang@example.com",
                    Email = "wchang@example.com",
                    PhoneNumber = "220-613-2686",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    LastName = "Chang",
                    Birthday = DateTime.ParseExact("1955-08-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "894 Kim Junction",
                    City = "Eagle Pass",
                    State = "TX",
                    ZipCode = "78852",
                },
                Password = "alaskaboy",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "limchou@gogle.com",
                    Email = "limchou@gogle.com",
                    PhoneNumber = "728-717-9608",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    LastName = "Chou",
                    Birthday = DateTime.ParseExact("2009-04-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "703 Anthes Lane",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78729",
                },
                Password = "allyrally",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "shdixon@aoll.com",
                    Email = "shdixon@aoll.com",
                    PhoneNumber = "338-796-7818",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    LastName = "Dixon",
                    Birthday = DateTime.ParseExact("1989-10-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "45927 Forest Run Trail",
                    City = "Georgetown",
                    State = "TX",
                    ZipCode = "78628",
                },
                Password = "Anchorage",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",
                    PhoneNumber = "878-921-1122",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    Birthday = DateTime.ParseExact("2001-10-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "51 Miller Park",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                },
                Password = "billyboy",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "feeley@penguin.org",
                    Email = "feeley@penguin.org",
                    PhoneNumber = "389-364-3017",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    Birthday = DateTime.ParseExact("1966-06-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "80686 Ryan Terrace",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78704",
                },
                Password = "bunnyhop",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",
                    PhoneNumber = "327-105-4962",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    Birthday = DateTime.ParseExact("1996-09-12", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "97327 Express Avenue",
                    City = "College Station",
                    State = "TX",
                    ZipCode = "77840",
                },
                Password = "dustydusty",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",
                    PhoneNumber = "480-950-2469",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    Birthday = DateTime.ParseExact("2002-06-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "1 Arrowood Road",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78756",
                },
                Password = "gowest",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "439-864-2291",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Haley",
                    Birthday = DateTime.ParseExact("1998-05-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "5035 Dayton Court",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78746",
                },
                Password = "hampton1",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",
                    PhoneNumber = "287-989-2098",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    Birthday = DateTime.ParseExact("2003-04-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "90461 Evergreen Place",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78756",
                },
                Password = "hickhickup",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",
                    PhoneNumber = "759-247-6853",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Hearn",
                    Birthday = DateTime.ParseExact("2000-09-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "973 Stephen Alley",
                    City = "Liberty",
                    State = "TX",
                    ZipCode = "77575",
                },
                Password = "ingram2015",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",
                    PhoneNumber = "603-447-9200",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    Birthday = DateTime.ParseExact("1980-05-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "80319 Forster Parkway",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78203",
                },
                Password = "jhearn22",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",
                    PhoneNumber = "965-996-5936",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "White",
                    Birthday = DateTime.ParseExact("1986-02-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "96 Stang Hill",
                    City = "New Braunfels",
                    State = "TX",
                    ZipCode = "78132",
                },
                Password = "joejoejoe",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",
                    PhoneNumber = "171-155-1224",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Birthday = DateTime.ParseExact("1975-08-29", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "23726 Main Crossing",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10101",
                },
                Password = "jrod2017",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",
                    PhoneNumber = "300-564-3682",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    Birthday = DateTime.ParseExact("2001-01-29", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "6299 Moland Alley",
                    City = "Lockhart",
                    State = "TX",
                    ZipCode = "78644",
                },
                Password = "longhorns",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",
                    PhoneNumber = "968-319-5113",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Erik",
                    LastName = "Lineback",
                    Birthday = DateTime.ParseExact("2004-05-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "6 Truax Street",
                    City = "Kingwood",
                    State = "TX",
                    ZipCode = "77325",
                },
                Password = "louielouie",
                RoleName = "Customer"
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",
                    PhoneNumber = "932-455-8010",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    Birthday = DateTime.ParseExact("2001-12-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    StreetAddress = "50883 Heath Park",
                    City = "Beverly Hills",
                    State = "CA",
                    ZipCode = "90210",
                },
                Password = "martin1234",
                RoleName = "Customer"
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
