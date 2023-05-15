using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application.Services
{
    public interface IMovieService
    {
        Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie);
        Task UpdateMovie(UpdateMovieRequest updateMovie);
        Task<IEnumerable<MovieListResponse>> GetAllMovies();

        Task AddPlayerToMovie(int movieId, List<int> players);
    }
}
