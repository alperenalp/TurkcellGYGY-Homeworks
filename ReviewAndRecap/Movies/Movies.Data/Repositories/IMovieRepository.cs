using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IList<Movie>> SearchMoviesByTitle(string title);
        Task AddPlayerToMovie(int movieId, List<int> selectedPlayers);
    }
}
