﻿using Microsoft.EntityFrameworkCore;
using Suits_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        // + System.IO.Path.GetFullPath("SuitsRentalDB.mdf") +
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string databasePath = Path.Combine(baseDirectory, "App_Data", "SuitsRentalDB.mdf");
            optionsBuilder.UseSqlServer("Server=.;Database=SuitsRentalDB;Trusted_Connection=true;TrustServerCertificate=True;");
            //Client Connection String//
            //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Suits Rental project\\Suits_Rental\\Suits_Rental\\Suits_Rental\\AppData\\SuitsRentalDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-QFAQ5R9;Initial Catalog=SuitsRentalDB;User Id=hotadm;Password=root;Encrypt=false;Trusted_Connection=True;Integrated Security=True;Connect Timeout=30;Encrypt=false;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suit>()
                .Property(S => S.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Order>()
                .Property(O => O.Discount)
                .HasDefaultValue(0);

            modelBuilder.Entity<User>()
                .HasIndex(U => U.UserName)
                .IsUnique();

            //modelBuilder.Entity<Order>()
            //    .Property(O => O.CustomerId)
            //    .HasDefaultValue(0);

            //modelBuilder.Entity<SuitOrder>()
            //    .Property(SO => SO.SuitId)
            //    .HasDefaultValue(0);

            modelBuilder.Entity<Order>()
                .HasOne(O => O.Customer)
                .WithMany(C => C.Orders)
                .HasForeignKey(O => O.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SuitOrder>()
                .HasOne(SO => SO.Suit)
                .WithMany(S => S.OrderSuits)
                .HasForeignKey(SO => SO.SuitId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderAttachmentSize>()
                .HasOne(OAS => OAS.Attachment_Size)
                .WithMany(AS => AS.OrderAttachmentSizes)
                .HasForeignKey(OAS => OAS.AttachmentSizeId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderAttachmentSize>()
                .HasOne(OAS => OAS.SuitBook)
                .WithMany(Sb => Sb.OrderAttachmentSizes)
                .HasForeignKey(OAS => OAS.SuitBookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SuitBook>()
                .HasOne(Sb => Sb.Order)
                .WithMany(O => O.SuitBooks)
                .HasForeignKey(Sb => Sb.OrderId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Suit> Suits { get; set; }
        public DbSet<SuitSize> SuitSizes { get; set; }
        public DbSet<Suit_Attachments> Suit_Attachments { get; set; }
        public DbSet<SuitBook> SuitBooks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SuitOrder> SuitOrders { get; set; }
        public DbSet<Attachment_Sizes> Attachment_Sizes { get; set; }
        public DbSet<OrderAttachmentSize> OrderAttachmentSizes { get; set; }
    }
}
