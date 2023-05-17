using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class EFMovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext moviesDbContext;

        public EFMovieRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public async Task DeletePlayerInMovie(int movieId, List<MoviesPlayer> selectedPlayers)
        {
            var movie = await moviesDbContext.Movies.FirstOrDefaultAsync(movie => movie.Id == movieId);
            foreach (var player in selectedPlayers)
            {
                movie.Players.Remove(player);
            }
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task AddPlayerToMovie(int movieId, List<MoviesPlayer> selectedPlayers)
        {
            var movie = await moviesDbContext.Movies.FirstOrDefaultAsync(movie => movie.Id == movieId);
            foreach(var player in selectedPlayers)
            {
                movie.Players.Add(player);
            }
            await moviesDbContext.SaveChangesAsync();
        }

        public void Create(Movie entity)
        {
            moviesDbContext.Movies.Add(entity);
            moviesDbContext.SaveChanges();
        }

        public async Task CreateAsync(Movie entity)
        {
            await moviesDbContext.Movies.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var movie = await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(movie => movie.Id == id);
            moviesDbContext.Movies.Remove(movie);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<IList<Movie>> GetAllAsync()
        {
            return await moviesDbContext.Movies.AsNoTracking()
                                               .Include(m=>m.Director)
                                               .Include(m=>m.Players)
                                               .ThenInclude(mp=>mp.Player)
                                               .ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(movie =>movie.Id == id);
        }

        public async Task<IList<Movie>> SearchMoviesByTitle(string title)
        {
            return await moviesDbContext.Movies.AsNoTracking().Where(movie => movie.Name.Contains(title)).ToListAsync();
        }

        public async Task UpdateAsync(Movie entity)
        {
            moviesDbContext.Movies.Update(entity);
            await moviesDbContext.SaveChangesAsync();
        }
    }
}
