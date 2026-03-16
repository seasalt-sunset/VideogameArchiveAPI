using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class DeveloperMappers
    {
        public static DeveloperDetailsDTO ToDetailsDTO(this Developer developer)
        {
            return new DeveloperDetailsDTO
            {
                DeveloperId = developer.DeveloperId,
                DeveloperName = developer.DeveloperName,
                GameList = developer.GameList.Select(g => g.ToSlimDTO()).ToList()
            };
        }

        public static DeveloperSlimDTO ToSlimDTO(this Developer developer)
        {
            return new DeveloperSlimDTO
            {
                DeveloperId = developer.DeveloperId,
                DeveloperName = developer.DeveloperName
            };
        }

        public static DeveloperDetailsSaveDTO ToDetailsSaveDTO(this Developer developer)
        {
            return new DeveloperDetailsSaveDTO
            {
                DeveloperName = developer.DeveloperName,
                GameIdsList = developer.GameList.Select(g => g.GameId).ToList()
            };
        }

        public static Developer ToEntity(this DeveloperDetailsSaveDTO developerDetailsSaveDTO)
        {
            return new Developer
            {
                DeveloperName = developerDetailsSaveDTO.DeveloperName,
                GameList = developerDetailsSaveDTO.GameIdsList.Select(id => new Videogame { GameId = id }).ToList()
            };
        }
    }
}
