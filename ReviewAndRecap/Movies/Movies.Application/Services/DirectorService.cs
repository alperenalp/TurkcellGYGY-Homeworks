using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public async Task<int> CreateNewDirectorAsync(CreateDirectorRequest request)
        {
            var director = new Director
            {
                Name = request.Name,
                LastName = request.LastName,
                Info = request.Info
            };
            await directorRepository.CreateAsync(director);
            return director.Id;
        }

        public async Task<SingleDirectorResponse> GetDirectorAsync(int id)
        {
            var director = await directorRepository.GetByIdAsync(id);
            var response = new SingleDirectorResponse
            {
                Id = director.Id,
                Name = director.Name,
                Info = director.Info,
                LastName = director.LastName
            };
            return response;
        }

        public async Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync()
        {
            var directors = await directorRepository.GetAllAsync();
            var response = directors.Select(d => new DirectorListResponse
            {
                Id = d.Id,
                Name = d.Name,
                Info = d.Info,
                LastName = d.LastName
            });
            return response;
        }

        public async Task UpdateDirectorAsync(UpdateDirectorRequest request)
        {
            var director = new Director
            {
                Name = request.Name,
                LastName = request.LastName,
                Info = request.Info,
                Id = request.Id
            };
            await directorRepository.UpdateAsync(director);
        }
    }
}
