using Microsoft.EntityFrameworkCore;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=desktop-qfaq5r9;Initial Catalog=SuitsRentalDB;User Id=hotadm;Password=root;encrypt=false;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suit>()
                .Property(O => O.Id)
                .ValueGeneratedNever();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Suit> Suits { get; set; }
        public DbSet<Suit_Attachments> Suit_Attachments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SuitOrder> SuitOrders { get; set; }
    }
}
