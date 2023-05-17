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
    public class EFPlayerRepository : IPlayerRepository
    {
        private readonly MoviesDbContext moviesDbContext;

        public EFPlayerRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public void Create(Player entity)
        {
            moviesDbContext.Players.Add(entity);
            moviesDbContext.SaveChanges();
        }

        public async Task CreateAsync(Player entity)
        {
            await moviesDbContext.Players.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var player = await moviesDbContext.Players.AsNoTracking().FirstOrDefaultAsync(player => player.Id == id);
            moviesDbContext.Players.Remove(player);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<IList<Player>> GetAllAsync()
        {
            return await moviesDbContext.Players.AsNoTracking().ToListAsync();
        }

        public async Task<Player?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Players.AsNoTracking().FirstOrDefaultAsync(player=> player.Id == id);
        }

        public async Task UpdateAsync(Player entity)
        {
            moviesDbContext.Players.Update(entity);
            await moviesDbContext.SaveChangesAsync();
        }
    }
}
