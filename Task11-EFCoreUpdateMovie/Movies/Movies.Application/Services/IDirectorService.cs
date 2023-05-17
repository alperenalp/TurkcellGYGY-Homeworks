using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public interface IDirectorService
    {
        Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync();
        Task<int> CreateNewDirectorAsync(CreateDirectorRequest request);
        Task<SingleDirectorResponse> GetDirectorAsync(int id);
        Task UpdateDirectorAsync(UpdateDirectorRequest request);

    }
}
