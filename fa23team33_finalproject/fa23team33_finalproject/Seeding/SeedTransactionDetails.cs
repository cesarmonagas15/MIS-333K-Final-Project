
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


    public static class SeedTransactionDetail
    {
        public static void SeedTransactionDetails(AppDbContext db)
        {
            List<TransactionDetail> AllTransactionDetails = new List<TransactionDetail>();


            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "A1",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "A2",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "A3",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "A4",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "A5",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "B1",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "B2",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "B3",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "B4",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 1),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "B5",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "A1",
                Theater = Theater.Theater1,
                TicketPrice = 10,
                PopcornPoints = 10,
                SeniorDiscount = true,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "A2",
                Theater = Theater.Theater1,
                TicketPrice = 10,
                PopcornPoints = 10,
                SeniorDiscount = true,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "A3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "A4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "A5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "B1",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "B2",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "B3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "B4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 2),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 16:30:00") && c.Movies.Title == "The Secret Life of Walter Mitty"),
                Movie = "The Secret Life of Walter Mitty",
                DateTime = DateTime.Parse("2023-11-24 16:30:00"),
                Seat = "B5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 3),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "C2",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 3),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "C3",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 4),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "C4",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 4),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-23 11:00:00") && c.Movies.Title == "Jurassic Park"),
                Movie = "Jurassic Park",
                DateTime = DateTime.Parse("2023-11-23 11:00:00"),
                Seat = "C5",
                Theater = Theater.Theater2,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 5),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "A1",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 6),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "A2",
                Theater = Theater.Theater1,
                TicketPrice = 10,
                PopcornPoints = 10,
                SeniorDiscount = true,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 7),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "A3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 8),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "A4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 9),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "A5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 10),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "B1",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 11),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "B2",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 12),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "B3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 13),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "B4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 14),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "B5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 15),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "E1",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 16),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "E2",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 17),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "E3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 18),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "E4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 19),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "E5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 20),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "C4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 21),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-24 21:00:00") && c.Movies.Title == "The Goonies"),
                Movie = "The Goonies",
                DateTime = DateTime.Parse("2023-11-24 21:00:00"),
                Seat = "C5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 22),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "D1",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 23),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "A2",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 24),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "A3",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 25),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "A4",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 26),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "A5",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 27),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "B1",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 28),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "B2",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 29),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "B3",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 30),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "B4",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 31),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "B5",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 32),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "E1",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 33),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "E2",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 34),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "E3",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 35),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "E4",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 36),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "E5",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 37),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "C4",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 38),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 21:00:00") && c.Movies.Title == "The Hobbit: The Battle of Five Armies"),
                Movie = "The Hobbit: The Battle of Five Armies",
                DateTime = DateTime.Parse("2023-11-25 21:00:00"),
                Seat = "C5",
                Theater = Theater.Theater1,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 39),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "D1",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 39),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "A2",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 39),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "A3",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "A4",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "A5",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "B1",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "B2",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "B3",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 40),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "B4",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 41),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "B5",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 41),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "E1",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 42),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "E2",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 42),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "E3",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 43),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "E4",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 43),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "E5",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 43),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "C4",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 43),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 19:30:00") && c.Movies.Title == "Lord of the Rings: The Return of the King"),
                Movie = "Lord of the Rings: The Return of the King",
                DateTime = DateTime.Parse("2023-11-25 19:30:00"),
                Seat = "C5",
                Theater = Theater.Theater2,
                TicketPrice = 15,
                PopcornPoints = 15,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 44),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "B2",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 44),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "B3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 44),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "B4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 45),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "B5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 46),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "E1",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 46),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "E2",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 47),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "E3",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 47),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "E4",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 48),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 12:00:00") && c.Movies.Title == "Titanic: Jack's Revenge"),
                Movie = "Titanic: Jack's Revenge",
                DateTime = DateTime.Parse("2023-11-25 12:00:00"),
                Seat = "E5",
                Theater = Theater.Theater1,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 49),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-25 09:00:00") && c.Movies.Title == "Toy Story 7"),
                Movie = "Toy Story 7",
                DateTime = DateTime.Parse("2023-11-25 09:00:00"),
                Seat = "E5",
                Theater = Theater.Theater2,
                TicketPrice = 12,
                PopcornPoints = 12,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "A4",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "E1",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "E2",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "E3",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "E4",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "E5",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "B3",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "B4",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 50),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-11-27 11:00:00") && c.Movies.Title == "Fast and Furious 18: Anger Management"),
                Movie = "Fast and Furious 18: Anger Management",
                DateTime = DateTime.Parse("2023-11-27 11:00:00"),
                Seat = "B5",
                Theater = Theater.Theater1,
                TicketPrice = 5,
                PopcornPoints = 5,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 51),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-12-04 22:00:00") && c.Movies.Title == "Rocky Horror Picture Show"),
                Movie = "Rocky Horror Picture Show",
                DateTime = DateTime.Parse("2023-12-04 22:00:00"),
                Seat = "C3",
                Theater = Theater.Theater2,
                TicketPrice = 0,
                PopcornPoints = -100,
                SeniorDiscount = false,



            });
            AllTransactionDetails.Add(new TransactionDetail()
            {
                Transaction = db.Transactions.FirstOrDefault(c => c.TransactionID == 51),
                Schedules = db.Schedules.FirstOrDefault(c => c.DateTime == DateTime.Parse("2023-12-04 22:00:00") && c.Movies.Title == "Rocky Horror Picture Show"),
                Movie = "Rocky Horror Picture Show",
                DateTime = DateTime.Parse("2023-12-04 22:00:00"),
                Seat = "C4",
                Theater = Theater.Theater2,
                TicketPrice = 0,
                PopcornPoints = -100,
                SeniorDiscount = false,



            });
            db.TransactionDetails.AddRange(AllTransactionDetails);
            db.SaveChanges();
        }
    }
}