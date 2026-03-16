using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class PublisherMappers
    {
        public static PublisherDetailsDTO ToDetailsDTO(this Publisher publisher)
        {
            return new PublisherDetailsDTO
            {
                PublisherId = publisher.PublisherId,
                PublisherName = publisher.PublisherName,
                GameList = publisher.GameList.Select(g => g.ToSlimDTO()).ToList(),
                GamingConsolesList = publisher.GamingConsolesList.Select(g => g.ToSlimDTO()).ToList()
            };
        }
        public static PublisherSlimDTO ToSlimDTO(this Publisher publisher)
        {
            return new PublisherSlimDTO
            {
                PublisherId = publisher.PublisherId,
                PublisherName = publisher.PublisherName
            };
        }

        public static PublisherDetailsSaveDTO ToSaveDTO(this Publisher publisher)
        {
            return new PublisherDetailsSaveDTO
            {
                PublisherName = publisher.PublisherName,
                GameIdsList = publisher.GameList.Select(g => g.GameId).ToList(),
                GamingConsolesIdsList = publisher.GamingConsolesList.Select(g => g.PlatformId).ToList()
            };
        }
    }
}
