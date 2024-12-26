
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using fa23team33_finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using System.Diagnostics;

namespace fa23team33_finalproject.Seeding
{
    public static class SeedMovies
    {
        //You will call this method from the SeedController to add categories
        public static void SeedAllMovies(AppDbContext db)
        {
            //create a list of categories to add
            List<Movie> AllMovies = new List<Movie>();


            AllMovies.Add(new Movie()
            {
                Title = "Jurassic Park",
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                Tagline = "Welcome to Jurassic Park",
                ReleaseYear = 1993,
                MPAArating = "PG-13",
                Actors = "Sam Neill, Laura Dern, Jeff Goldblum",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Drama")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Toy Story 7",
                Description = "Woody and Buzz team up once again to lead the resistance in the Toy Revolt.",
                Tagline = "Play, pretend, and protect",
                ReleaseYear = 2023,
                MPAArating = "G",
                Actors = "Tom Hanks, Tim Allen",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Children and Family")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Fast and Furious 18: Anger Management",
                Description = "They may be riding mechanical scooters, but they are as furious as ever as they attend court-ordered therapy.",
                Tagline = "I drink your milkshake",
                ReleaseYear = 2023,
                MPAArating = "R",
                Actors = "The Rock, Vin Diesel",
                RunTime = 120,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Action")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Titanic",
                Description = "An epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic.",
                Tagline = "Nothing On Earth Could Come Between Them. Collide With Destiny.",
                ReleaseYear = 1999,
                MPAArating = "PG-13",
                Actors = "Leonardo DiCaprio, Kate Winslet",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Romance")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Secret Life of Walter Mitty",
                Description = "When both he and a colleague are about to lose their job, Walter takes action by embarking on an adventure more extraordinary than anything he ever imagined.",
                Tagline = "Stop dreaming. Start Living.",
                ReleaseYear = 2013,
                MPAArating = "PG",
                Actors = "Ben Stiller",
                RunTime = 120,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Comedy")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Goonies",
                Description = "A group of young misfits called The Goonies discover an ancient map and set out on an adventure to find a legendary pirate's long-lost treasure.",
                Tagline = "The treacherous traps. The hidden treasure. And Sloth... Join the adventure.",
                ReleaseYear = 1985,
                MPAArating = "PG",
                Actors = "Sean Astin, Josh Brolin, Corey Feldman",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Children and Family")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Sandlot",
                Description = "When Scottie Smalls moves to a new neighborhood, he manages to make friends with a group of kids who play baseball at the sandlot.",
                Tagline = "The adventure of a lifetime, the summer of their dreams...the dog of their nightmares.",
                ReleaseYear = 1993,
                MPAArating = "PG",
                Actors = "Mike Vitar, Patrick Renna, James Earl Jones",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Children and Family")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Rocky Horror Picture Show",
                Description = "A newly-engaged couple have a breakdown in an isolated area and must seek shelter at the bizarre residence of Dr. Frank-n-Furter",
                Tagline = "Don't Dream it, Be It!",
                ReleaseYear = 1975,
                MPAArating = "R",
                Actors = "Tim Curry, Susan Sarandon",
                RunTime = 90,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Musical")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Titanic: Jack's Revenge",
                Description = "Emerging from the deep with revenge on his mind, Jack Dawson will stop at nothing to find Rose.",
                Tagline = "She let me go, now I'll never let her forget it.",
                ReleaseYear = 2023,
                MPAArating = "R",
                Actors = "Leonardo DiCaprio, Kate Winslet",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Horror")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Hobbit: An Unexpected Journey",
                Description = "An Unexpected Journey tells the tale of Bilbo Baggins, who is convinced by the wizard Gandalf to accompany thirteen Dwarves, led by Thorin Oakenshield, on a quest to reclaim the Lonely Mountain from the dragon Smaug.",
                Tagline = "From the smallest beginnings come the greatest legends. One journey started it all.",
                ReleaseYear = 2012,
                MPAArating = "PG-13",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Hobbit: The Battle of Five Armies",
                Description = "Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.",
                Tagline = "The defining chapter.",
                ReleaseYear = 2014,
                MPAArating = "PG-13",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "The Hobbit: The Desolation of Smaug",
                Description = "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug.",
                Tagline = "It's a really big dragon",
                ReleaseYear = 2013,
                MPAArating = "PG-13",
                Actors = "Martin Freeman, Ian McKellan, Richard Armitage",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Lord of the Rings: Fellowship of the Ring",
                Description = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins, who inherits the Ring and steps into legend.",
                Tagline = "One Ring To Rule Them All. Fate Has Chosen Him. A Fellowship Will Protect Him. Evil Will Hunt Them.",
                ReleaseYear = 2001,
                MPAArating = "PG-13",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Lord of the Rings: Two Towers",
                Description = "Frodo and Sam discover they are being followed by the mysterious Gollum.",
                Tagline = "A New Power Is Rising. The Battle for Middle-earth Begins!",
                ReleaseYear = 2002,
                MPAArating = "PG-13",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Lord of the Rings: The Return of the King",
                Description = "Continuing the plot of the previous film, Frodo, Sam and Gollum are making their final way toward Mount Doom to destroy the One Ring, unaware of Gollum's true intentions, while Merry, Pippin, Gandalf, Aragorn, Legolas, Gimli and the others join forces together against Sauron and his legions in Minas Tirith.",
                Tagline = "No victory without suffering. No freedom without sacrifice.",
                ReleaseYear = 2003,
                MPAArating = "PG-13",
                Actors = "Elijah Wood, Sam Astin, Orlando Bloom, Viggo Mortenson, Billy Boyd, Dominic Monaghan, Sean Bean",
                RunTime = 180,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Science Fiction")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Barbie",
                Description = "Stereotypical Barbie experiences a full on existential crisis and embarks on a journey of self discovery. Along for the ride is her beau Ken.",
                Tagline = "She can do everything. He's just Ken.",
                ReleaseYear = 2023,
                MPAArating = "PG-13",
                Actors = "Ryan Gosling, Margot Robbie",
                RunTime = 120,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Comedy")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Spider-Man: Into the Spider-Verse",
                Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                Tagline = "Enter a universe where more than one wears the mask.",
                ReleaseYear = 2018,
                MPAArating = "PG",
                Actors = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Stan Lee, Oscar Isaac, Nicolas Cage, Mahershala Ali",
                RunTime = 120,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Action")

            });
            AllMovies.Add(new Movie()
            {
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence.",
                Tagline = "With great power comes great responsibility.",
                ReleaseYear = 2023,
                MPAArating = "PG",
                Actors = "Shameik Moore, Hailee Steinfeld, Oscar Isaac, Karan Soni, Andy Samberg, Daniel Kaluuya",
                RunTime = 150,
                Genre = db.Genre.FirstOrDefault(c => c.GenreName == "Action")

            });
            //create some counters to help debug problems
            Int32 intMovieID = 0;
            String strMovieTitle = "Start";

            //loop through the list to add or update the job posting
            try
            {
                foreach (Movie seedMovie in AllMovies)
                {
                    //update the counters
                    intMovieID = seedMovie.MovieID;
                    strMovieTitle = seedMovie.Title;
                    //see if the job posting is already in the database using the UniqueIdentifier
                    Movie dbMovie= db.Movies.FirstOrDefault(m => m.MovieID == seedMovie.MovieID);

                    //if job posting is null, job posting is not in database
                    if (dbMovie == null)
                    {
                        //Add the job posting to the database
                        db.Movies.Add(seedMovie);
                        db.SaveChanges();
                    }
                    else //the job posting is in the database - reset all fields except ID and Unique Identifier
                    {
                        dbMovie.Title = seedMovie.Title;
                        dbMovie.Description = seedMovie.Description;
                        dbMovie.Tagline = seedMovie.Tagline;
                        dbMovie.ReleaseYear = seedMovie.ReleaseYear;
                        dbMovie.MPAArating = seedMovie.MPAArating;
                        dbMovie.Actors = seedMovie.Actors;
                        dbMovie.RunTime = seedMovie.RunTime;
                        dbMovie.Genre = seedMovie.Genre;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(strMovieTitle);
                msg.Append(" (MovieID: ");
                msg.Append(intMovieID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}