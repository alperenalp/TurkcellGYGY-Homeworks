using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<int> CreateNewPlayer(CreateNewPlayerRequest request)
        {
            var player = new Player
            {
                Name = request.Name,
                LastName = request.LastName,
                Info = request.Info
            };
            await playerRepository.CreateAsync(player);
            return player.Id;
        }

        public async Task<IEnumerable<PlayerListResponse>> GetPlayerLists()
        {
            var players = await playerRepository.GetAllAsync();
            var response = players.Select(pl => new PlayerListResponse
            {
                Name=pl.Name,
                LastName=pl.LastName,
                Info = pl.Info,
                Id = pl.Id
            });
            return response;
        }

        public async Task UpdatePlayer(UpdatePlayerRequest request)
        {
            var player = new Player
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Info = request.Info
            };
            await playerRepository.UpdateAsync(player);
        }
    }
}
