using System;
using Microsoft.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using fa23team33_finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

//TODO: Make this namespace match your project name
namespace fa23team33_finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
 
        }


        //TODO: Add Dbsets here.  Products is included as an example.  
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
