using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public interface IPlayerService
    {
        Task<int> CreateNewPlayer(CreateNewPlayerRequest request);
        Task<IEnumerable<PlayerListResponse>> GetPlayerLists();
        Task UpdatePlayer(UpdatePlayerRequest request);
    }
}
