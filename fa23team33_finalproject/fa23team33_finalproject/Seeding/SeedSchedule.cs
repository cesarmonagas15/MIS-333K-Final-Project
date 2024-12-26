using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using fa23team33_finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace fa23team33_finalproject.Seeding
{

    public static class SeedSchedule

    {
        public static Movie FindOrCreateMovie(string movieTitle, AppDbContext db)
        {
            // Check if the movie with the given title exists
            var existingMovie = db.Movies.FirstOrDefault(m => m.Title == movieTitle);

            if (existingMovie != null)
            {
                // If the movie exists, return the existing movie
                return existingMovie;
            }

            // If the movie doesn't exist, create a new one
            var newMovie = new Movie
            {
                Title = movieTitle,
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                Tagline = "Welcome to Jurassic Park",
                ReleaseYear = 1993,
                MPAArating = "PG-13",
                Actors = "Sam Neill, Laura Dern, Jeff Goldblum",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Drama")
            };

            // Add the new movie to the DbSet and save changes
            db.Add(newMovie);
            db.SaveChanges();

            // Return the newly created movie
            return newMovie;
        }
        public static void SeedAllSchedule(AppDbContext db)
        {
            List<Schedule> AllSchedule = new List<Schedule>();

            

            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-23 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false ,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-23 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-23 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-23 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-23 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-23 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-23 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-23 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-23 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-24 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-23 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-24 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-24 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-11-24 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-24 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-24 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-24 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-24 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-24 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-24 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-24 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-24 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-25 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: An Unexpected Journey", db),
                DateTime = DateTime.Parse("2023-11-25 15:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Desolation of Smaug", db),
                DateTime = DateTime.Parse("2023-11-25 18:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Battle of Five Armies", db),
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-25 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-25 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Fellowship of the Ring", db),
                DateTime = DateTime.Parse("2023-11-25 13:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Two Towers", db),
                DateTime = DateTime.Parse("2023-11-25 16:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: The Return of the King", db),
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-26 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-11-26 12:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: An Unexpected Journey", db),
                DateTime = DateTime.Parse("2023-11-26 15:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Desolation of Smaug", db),
                DateTime = DateTime.Parse("2023-11-26 18:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Battle of Five Armies", db),
                DateTime = DateTime.Parse("2023-11-26 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-26 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-26 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Fellowship of the Ring", db),
                DateTime = DateTime.Parse("2023-11-26 13:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Two Towers", db),
                DateTime = DateTime.Parse("2023-11-26 16:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: The Return of the King", db),
                DateTime = DateTime.Parse("2023-11-26 19:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-27 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-27 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-27 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-27 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-27 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-27 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-27 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-27 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-27 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-27 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-27 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-28 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-28 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-28 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-28 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-28 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-28 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-28 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-28 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-28 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-28 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-28 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-28 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-28 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-29 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-29 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-11-29 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-29 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-29 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-29 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-29 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-29 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-29 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-29 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-29 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-29 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-29 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-30 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-30 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-11-30 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-30 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-30 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-30 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-11-30 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-11-30 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-11-30 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-11-30 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-11-30 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-11-30 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-11-30 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-01 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-01 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-12-01 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-01 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-01 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-01 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-01 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-01 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-01 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-01 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-01 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-12-01 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-12-01 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-12-02 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-12-02 12:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: An Unexpected Journey", db),
                DateTime = DateTime.Parse("2023-12-02 15:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Desolation of Smaug", db),
                DateTime = DateTime.Parse("2023-12-02 18:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Battle of Five Armies", db),
                DateTime = DateTime.Parse("2023-12-02 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-02 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-02 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Fellowship of the Ring", db),
                DateTime = DateTime.Parse("2023-12-02 13:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Two Towers", db),
                DateTime = DateTime.Parse("2023-12-02 16:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: The Return of the King", db),
                DateTime = DateTime.Parse("2023-12-02 19:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-12-03 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-12-03 12:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: An Unexpected Journey", db),
                DateTime = DateTime.Parse("2023-12-03 15:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Desolation of Smaug", db),
                DateTime = DateTime.Parse("2023-12-03 18:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Hobbit: The Battle of Five Armies", db),
                DateTime = DateTime.Parse("2023-12-03 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-03 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-03 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Fellowship of the Ring", db),
                DateTime = DateTime.Parse("2023-12-03 13:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: Two Towers", db),
                DateTime = DateTime.Parse("2023-12-03 16:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Weekends,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Lord of the Rings: The Return of the King", db),
                DateTime = DateTime.Parse("2023-12-03 19:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.SpecialEvent,
                SpecialEvent = true,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-04 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-04 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-12-04 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-04 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-04 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-04 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-04 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-04 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-04 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-04 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-04 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-12-04 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-12-04 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-05 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-05 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-12-05 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-05 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-05 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-05 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-05 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-05 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-05 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-05 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.DiscountTuesday,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-05 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-12-05 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-12-05 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-06 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-06 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic", db),
                DateTime = DateTime.Parse("2023-12-06 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-06 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-06 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-06 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-06 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-06 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-06 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-06 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-06 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-12-06 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-12-06 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-07 09:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-07 11:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Titanic: Jack's Revenge", db),
                DateTime = DateTime.Parse("2023-12-07 13:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-07 16:30:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-07 19:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-07 21:00:00"),
                Theater = Theater.Theater1,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Toy Story 7", db),
                DateTime = DateTime.Parse("2023-12-07 09:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Jurassic Park", db),
                DateTime = DateTime.Parse("2023-12-07 11:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.Matinee,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Secret Life of Walter Mitty", db),
                DateTime = DateTime.Parse("2023-12-07 13:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Fast and Furious 18: Anger Management", db),
                DateTime = DateTime.Parse("2023-12-07 15:30:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Goonies", db),
                DateTime = DateTime.Parse("2023-12-07 18:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("The Sandlot", db),
                DateTime = DateTime.Parse("2023-12-07 20:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });
            AllSchedule.Add(new Schedule()
            {
                Movies = FindOrCreateMovie("Rocky Horror Picture Show", db),
                DateTime = DateTime.Parse("2023-12-07 22:00:00"),
                Theater = Theater.Theater2,
                Price = TicketType.WeekdayBase,
                SpecialEvent = false,


            });

            db.Schedules.AddRange(AllSchedule);
            db.SaveChanges();
        }
    }
}