
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


    public static class SeedTransaction
    {
        public static void SeedTransactions(AppDbContext db)
        {

            Int32 intTransactionsAdded = 0;
            Int32 strTransactionID = 1;
        List<Transaction> AllTransactions = new List<Transaction>();


        Transaction t1 = new Transaction()
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 50,
                TicketCount = 10,
                PopcornPoints = 50,
                Status = TransactionStatus.Purchased
        };
        t1.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Michelle") || c.LastName.Contains("Banks"));
        AllTransactions.Add(t1);
        Transaction t2 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-05 00:00:00"),
                TransactionSubtotal = 116,
                TicketCount = 10,
                PopcornPoints = 116,
                Status = TransactionStatus.Purchased
        };
        t2.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t2);
            Transaction t3 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 10,
                TicketCount = 2,
                PopcornPoints = 10,
                Status = TransactionStatus.Purchased
        };
            t3.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t3);
            Transaction t4 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-14 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t4.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Michelle") || c.LastName.Contains("Banks"));
            AllTransactions.Add(t4);
        Transaction t5 = new Transaction()

        {
                TransactionDate = DateTime.Parse("2023-11-05 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t5.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Franco") || c.LastName.Contains("Broccolo"));
            AllTransactions.Add(t5);
            Transaction t6 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 10,
                TicketCount = 1,
                PopcornPoints = 10,
                Status = TransactionStatus.Purchased



        };
            t6.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Wendy") || c.LastName.Contains("Chang"));
            AllTransactions.Add(t6);
            Transaction t7 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-14 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t7.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lim") || c.LastName.Contains("Chou"));
            AllTransactions.Add(t7);
            Transaction t8 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t8.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t8);
            Transaction t9 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-05 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t9.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Shan") || c.LastName.Contains("Dixon"));
            AllTransactions.Add(t9);
            Transaction t10 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t10.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Jim") || c.LastName.Contains("Bob Evans"));
            AllTransactions.Add(t10);
            Transaction t11 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-14 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t11.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lou") || c.LastName.Contains("Ann Feeley"));
            AllTransactions.Add(t11);
            Transaction t12 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t12.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t12);
            Transaction t13 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-05 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t13.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Victoria") || c.LastName.Contains("Lawrence"));
            AllTransactions.Add(t13);
            Transaction t14 = new Transaction() 
        {

                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Cancelled,
        };
            t14.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Erik") || c.LastName.Contains("Lineback"));
            AllTransactions.Add(t14);
            Transaction t15 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-14 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t15.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Ernest") || c.LastName.Contains("Lowe"));
            AllTransactions.Add(t15);
            Transaction t16 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t16.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t16);
            Transaction t17 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t17.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t17);
            Transaction t18 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t18.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t18);
            Transaction t19 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t19.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t19);
            Transaction t20 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t20.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t20);
            Transaction t21 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-20 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t21.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t21);
            Transaction t22 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t22.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Michelle") || c.LastName.Contains("Banks"));
            AllTransactions.Add(t22);
            Transaction t23 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t23.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t23);
            Transaction t24 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t24.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t24);
            Transaction t25 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t25.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Michelle") || c.LastName.Contains("Banks"));
            AllTransactions.Add(t25);
            Transaction t26 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t26.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Franco") || c.LastName.Contains("Broccolo"));
            AllTransactions.Add(t26);
            Transaction t27 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t27.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Wendy") || c.LastName.Contains("Chang"));
            AllTransactions.Add(t27);
            Transaction t28 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t28.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lim") || c.LastName.Contains("Chou"));
            AllTransactions.Add(t28);
            Transaction t29 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Cancelled,
        };
            t29.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Shan") || c.LastName.Contains("Dixon"));
            AllTransactions.Add(t29);
            Transaction t30 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t30.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Jim") || c.LastName.Contains("Bob Evans"));
            AllTransactions.Add(t30);
            Transaction t31 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t31.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lou") || c.LastName.Contains("Ann Feeley"));
            AllTransactions.Add(t31);
            Transaction t32 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t32.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Victoria") || c.LastName.Contains("Lawrence"));
            AllTransactions.Add(t32);
            Transaction t33 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Cancelled,
        };
            t33.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Erik") || c.LastName.Contains("Lineback"));
            AllTransactions.Add(t33);
            Transaction t34 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased

        };
            t34.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Ernest") || c.LastName.Contains("Lowe"));
            AllTransactions.Add(t34);
            Transaction t35 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t35.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t35);
            Transaction t36 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t36.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t36);
            Transaction t37 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t37.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t37);
            Transaction t38 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 15,
                TicketCount = 1,
                PopcornPoints = 15,
                Status = TransactionStatus.Purchased
        };
            t38.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t38);
            Transaction t39 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 30,
                TicketCount = 2,
                PopcornPoints = 30,
                Status = TransactionStatus.Purchased
        };
            t39.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t39);
            Transaction t40 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 90,
                TicketCount = 6,
                PopcornPoints = 90,
                Status = TransactionStatus.Purchased
        };
            t40.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t40);
            Transaction t41 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 30,
                TicketCount = 2,
                PopcornPoints = 30,
                Status = TransactionStatus.Cancelled,
        };
            t41.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Michelle") || c.LastName.Contains("Banks"));
            AllTransactions.Add(t41);
            Transaction t42 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 30,
                TicketCount = 2,
                PopcornPoints = 30,
                Status = TransactionStatus.Purchased
        };
            t42.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Jim") || c.LastName.Contains("Bob Evans"));
            AllTransactions.Add(t42);
            Transaction t43 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 60,
                TicketCount = 4,
                PopcornPoints = 60,
                Status = TransactionStatus.Purchased
        };
            t43.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lou") || c.LastName.Contains("Feeley"));
            AllTransactions.Add(t43);
            Transaction t44 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 36,
                TicketCount = 3,
                PopcornPoints = 36,
                Status = TransactionStatus.Purchased
        };
            t44.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Brad") || c.LastName.Contains("White"));
            AllTransactions.Add(t44);
            Transaction t45 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t45.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Victoria") || c.LastName.Contains("Lawrence"));
            AllTransactions.Add(t45);
            Transaction t46 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 24,
                TicketCount = 2,
                PopcornPoints = 24,
                Status = TransactionStatus.Purchased
        };
            t46.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Franco") || c.LastName.Contains("Broccolo"));
            AllTransactions.Add(t46);
            Transaction t47 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 20,
                TicketCount = 2,
                PopcornPoints = 20,
                Status = TransactionStatus.Purchased
        };
            t47.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Wendy") || c.LastName.Contains("Chang"));
            AllTransactions.Add(t47);
            Transaction t48 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-01 00:00:00"),
                TransactionSubtotal = 10,
                TicketCount = 1,
                PopcornPoints = 10,
                Status = TransactionStatus.Purchased
        };
            t48.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Christopher") || c.LastName.Contains("Baker"));
            AllTransactions.Add(t48);
            Transaction t49 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-15 00:00:00"),
                TransactionSubtotal = 12,
                TicketCount = 1,
                PopcornPoints = 12,
                Status = TransactionStatus.Purchased
        };
            t49.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Lim") || c.LastName.Contains("Chou"));
            AllTransactions.Add(t49);
            Transaction t50 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-24 00:00:00"),
                TransactionSubtotal = 45,
                TicketCount = 9,
                PopcornPoints = 45,
                Status = TransactionStatus.Cancelled,
        };
            t50.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Jim") || c.LastName.Contains("Bob Evans"));
            AllTransactions.Add(t50);
            Transaction t51 = new Transaction() 
        {
                TransactionDate = DateTime.Parse("2023-11-26 00:00:00"),
                TransactionSubtotal = 0,
                TicketCount = 2,
                PopcornPoints = -200,
                Status = TransactionStatus.Purchased

        };
            t51.User = db.Users.FirstOrDefault(c => c.FirstName.Contains("Jim") || c.LastName.Contains("Bob Evans"));
            AllTransactions.Add(t51);

            try
            {
                foreach (Transaction transactionToAdd in AllTransactions)
                {
                    strTransactionID = transactionToAdd.TransactionID;

                    Transaction dbTransaction = db.Transactions.FirstOrDefault(b => b.TransactionID == transactionToAdd.TransactionID);

                    if (dbTransaction == null)
                    {
                        db.Transactions.Add(transactionToAdd);
                        db.SaveChanges();

                        intTransactionsAdded += 1;
                    }
                    else
                    {
                        dbTransaction.TransactionDate = transactionToAdd.TransactionDate;
                        dbTransaction.TransactionStatus = transactionToAdd.Status;
                        dbTransaction.TransactionSubtotal = transactionToAdd.TransactionSubtotal;
                        dbTransaction.TicketCount = transactionToAdd.TicketCount;
                        dbTransaction.PopcornPoints = transactionToAdd.PopcornPoints;

                        db.Update(dbTransaction);
                        db.SaveChanges();

                        intTransactionsAdded += 1;
                    }
                }
            }

            catch (Exception ex)
            {
                String msg = "  Reviews added:" + intTransactionsAdded + "; Error on " + strTransactionID;

                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}