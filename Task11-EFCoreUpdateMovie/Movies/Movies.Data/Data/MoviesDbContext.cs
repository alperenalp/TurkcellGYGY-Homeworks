using Microsoft.EntityFrameworkCore;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Data
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(m => m.Name).IsRequired().HasMaxLength(250);


            modelBuilder.Entity<Movie>().HasOne(m => m.Director)
                                        .WithMany(d => d.Movies)
                                        .HasForeignKey(m => m.DirectorId)
                                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Movie>().HasMany(m => m.Players)
                                      .WithOne(mp => mp.Movie)
                                      .HasForeignKey(mp => mp.MovieId)
                                      .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Player>().HasMany(p => p.Movies)
                                         .WithOne(m => m.Player)
                                         .HasForeignKey(mp => mp.PlayerId)
                                         .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MoviesPlayer>().HasKey("PlayerId", "MovieId");

            modelBuilder.Entity<Director>().HasData(new Director { Id = 1, Name = "Peter", LastName = "Jackson" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 1, Name = "Orlando", LastName = "Bloom" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Name = "The Lord of the Rings: The Fellowship of the Ring", DirectorId = 1, Rating = 8.8 });
            modelBuilder.Entity<MoviesPlayer>().HasData(new MoviesPlayer { MovieId = 1, PlayerId = 1, Role = "Legolas" });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LikeImdb;Integrated Security=True");
        }
    }
}
