using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task AddPlayerToMovie(int movieId, List<int> players)
        {
            await movieRepository.AddPlayerToMovie(movieId, players);
        }

        public async Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie)
        {
            var movie = new Movie
            {
                Name = createNewMovie.Name,
                DirectorId = createNewMovie.DirectorId,
                Duration = createNewMovie.Duration,
                Rating = createNewMovie.Rating,
                Poster = createNewMovie.Poster,
                PublishDate = createNewMovie.PublishDate
            };
            await movieRepository.CreateAsync(movie);
            return movie.Id;
        }

        public async Task<IEnumerable<MovieListResponse>> GetAllMovies()
        {
            var movies = await movieRepository.GetAllAsync();
            var response = movies.Select(m => new MovieListResponse
            {
                Name =m.Name,
                DirectorId = m.DirectorId,
                Duration = m.Duration,
                Rating = m.Rating,
                Id = m.Id,
                DirectorName = $"{m.Director?.Name} {m.Director?.LastName}",
                Players = string.Join(", ", m.Players.Select(pl => new { FullName = $"{pl.Player.Name} {pl.Player.LastName} - {pl.Role}" }).ToList())
            });
            return response;
        }

        public Task UpdateMovie(UpdateMovieRequest updateMovie)
        {
            throw new NotImplementedException();
        }
    }
}
