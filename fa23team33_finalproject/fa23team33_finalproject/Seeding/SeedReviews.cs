
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


    public static class SeedReviews
    {
        //You will call this method from the SeedController to add reviews
        public static async Task SeedAllReviews(AppDbContext db)
        {
            Int32 intReviewsAdded = 0;
            Int32 strReviewID = 1;
            //create a list of categories to add
            List<Review> AllReviews = new List<Review>();
            Review r1 = new Review()
            {
                Rating = 5,
                Description = "Best movie I've ever seen.",
                Status = Status.Approved
            };
            r1.User = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks");
            r1.Movies = db.Movies.FirstOrDefault(g => g.Title == "Jurassic Park");
            AllReviews.Add(r1);

            Review r2 = new Review()
            {
                Rating = 4,
                Description = "Not bad.",
                Status = Status.Approved
            };
            r2.User = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker");
            r2.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Secret Life of Walter Mitty");
            AllReviews.Add(r2);

            Review r3 = new Review()
            {
                Rating = 5,
                Description = "Changed my life",
                Status = Status.Approved
            };
            r3.User = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White");
            r3.Movies = db.Movies.FirstOrDefault(g => g.Title == "Jurassic Park");
            AllReviews.Add(r3);

            Review r4 = new Review()
            {
                Rating = 5,
                Description = "Great family adventure movie",
                Status = Status.Approved
            };
            r4.User = db.Users.FirstOrDefault(g => g.FirstName == "Franco" && g.LastName == "Broccolo");
            r4.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r4);

            Review r5 = new Review()
            {
                Rating = 4,
                Description = "Good movie",
                Status = Status.Approved
            };
            r5.User = db.Users.FirstOrDefault(g => g.FirstName == "Wendy" && g.LastName == "Chang");
            r5.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r5);

            Review r6 = new Review()
            {
                Rating = 1,
                Description = "Worst thing I've ever seen",
                Status = Status.Approved
            };
            r6.User = db.Users.FirstOrDefault(g => g.FirstName == "Lim" && g.LastName == "Chou");
            r6.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r6);

            Review r7 = new Review()
            {
                Rating = 5,
                Description = "Reminded me of my summers in the NW",
                Status = Status.Approved
            };
            r7.User = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White");
            r7.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r7);

            Review r8 = new Review()
            {
                Rating = 5,
                Description = "I love a good treasure hunt!",
                Status = Status.NeedsReview
            };
            r8.User = db.Users.FirstOrDefault(g => g.FirstName == "Shan" && g.LastName == "Dixon");
            r8.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r8);

            Review r9 = new Review()
            {
                Rating = 3,
                Description = "Meh",
                Status = Status.Approved
            };
            r9.User = db.Users.FirstOrDefault(g => g.FirstName == "Jim Bob" && g.LastName == "Evans");
            r9.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Goonies");
            AllReviews.Add(r9);

            Review r10 = new Review()
            {
                Rating = 4,
                Status = Status.Approved
            };
            r10.User = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker");
            r10.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r10);

            Review r11 = new Review()
            {
                Rating = 4,
                Status = Status.Approved
            };
            r11.User = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White");
            r11.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r11);

            Review r12 = new Review()
            {
                Rating = 5,
                Status = Status.Approved
            };
            r12.User = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks");
            r12.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r12);

            Review r13 = new Review()
            {
                Rating = 5,
                Status = Status.Approved
            };
            r13.User = db.Users.FirstOrDefault(g => g.FirstName == "Franco" && g.LastName == "Broccolo");
            r13.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r13);

            Review r14 = new Review()
            {
                Rating = 1,
                Description = "Too long",
                Status = Status.NeedsReview
            };
            r14.User = db.Users.FirstOrDefault(g => g.FirstName == "Wendy" && g.LastName == "Chang");
            r14.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r14);

            Review r15 = new Review()
            {
                Rating = 2,
                Description = "Did they really need to drag this out into its own movie?",
                Status = Status.NeedsReview
            };
            r15.User = db.Users.FirstOrDefault(g => g.FirstName == "Lim" && g.LastName == "Chou");
            r15.Movies = db.Movies.FirstOrDefault(g => g.Title == "The Hobbit: The Battle of Five Armies");
            AllReviews.Add(r15);


            try
            {
                foreach (Review reviewToAdd in AllReviews)
                {
                    strReviewID = reviewToAdd.ReviewID;

                    Review dbReview = db.Reviews.FirstOrDefault(b => b.ReviewID == reviewToAdd.ReviewID);

                    if (dbReview == null)
                    {
                        db.Reviews.Add(reviewToAdd);
                        db.SaveChanges();

                        intReviewsAdded += 1;
                    }
                    else
                    {
                        dbReview.Rating = reviewToAdd.Rating;
                        dbReview.Description = reviewToAdd.Description;
                        dbReview.Status = reviewToAdd.Status;


                        db.Update(dbReview);
                        db.SaveChanges();

                        intReviewsAdded += 1;
                    }
                }
            }

            catch (Exception ex)
            {
                String msg = "  Reviews added:" + intReviewsAdded + "; Error on " + strReviewID;

                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}