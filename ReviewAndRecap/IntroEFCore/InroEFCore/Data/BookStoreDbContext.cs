using InroEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InroEFCore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=bookStoreSampleDb;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired()
                                                              .HasMaxLength(250);

            modelBuilder.Entity<Review>().HasOne(r => r.Book)
                                         .WithMany(b => b.Reviews)
                                         .HasForeignKey(r => r.BookId)
                                         .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
