using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class VideogameMappers
    {
        public static VideogameDetailsDTO ToDetailsDTO(this Videogame videogame)
        {
            return new VideogameDetailsDTO
            {
                GameId = videogame.GameId,
                GameName = videogame.GameName,
                ReleaseDate = videogame.ReleaseDate,
                MinPlayers = videogame.MinPlayers,
                MaxPlayers = videogame.MaxPlayers,
                EarlyAccess = videogame.EarlyAccess,
                DLCOfWhatGame = videogame.DLCOfWhatGame != null ? videogame.DLCOfWhatGame.ToSlimDTO() : null,
                FromVideogameCollection = videogame.FromVideogameCollection != null ? videogame.FromVideogameCollection.ToSlimDTO() : null,
                CollectionOfWhatGames = videogame.CollectionOfWhatGames != null ? videogame.CollectionOfWhatGames.Select(cog => cog.ToSlimDTO()).ToList() : null,
                DLCs = videogame.DLCs != null ? videogame.DLCs.Select(dlc => dlc.ToSlimDTO()).ToList() : null,
                GamingPlatforms = videogame.GamingPlatforms.Select(gp => gp.ToSlimDTO()).ToList(),
                SubscriptionServices = videogame.SubscriptionServices.Select(ss => ss.ToSlimDTO()).ToList(),
                Developers = videogame.Developers.Select(d => d.ToSlimDTO()).ToList(),
                Publishers = videogame.Publishers.Select(p => p.ToDetailsDTO()).ToList(),
                Genres = videogame.Genres.Select(g => g.ToSlimDTO()).ToList(),
                Tags = videogame.Tags.Select(t => t.ToSlimDTO()).ToList(),
                GameModes = videogame.GameModes.Select(gm => gm.ToSlimDTO()).ToList(),
                VideogameUsers = videogame.VideogameUsers != null ? videogame.VideogameUsers.Select(vgu => vgu.ToSlimDTO()).ToList() : null
            };
        }
}

        public static VideogameReducedDetailsDTO ToReducedDetailsDTO(this Videogame videogame)
        {
            return new VideogameReducedDetailsDTO
            {
                GameId = videogame.GameId,
                GameName = videogame.GameName,
                ReleaseDate = videogame.ReleaseDate,
                MinPlayers = videogame.MinPlayers,
                MaxPlayers = videogame.MaxPlayers,
                EarlyAccess = videogame.EarlyAccess,
                IsADLC = videogame.DLCOfWhatGame != null ? true : false,
                GamingPlatforms = videogame.GamingPlatforms.Select(gp => gp.PlatformName).ToList(),
                Developers = videogame.Developers.Select(d => d.DeveloperName).ToList(),
                Publishers = videogame.Publishers.Select(p => p.PublisherName).ToList(),
                Genres = videogame.Genres.Select(g => g.GenreName).ToList(),
                Tags = videogame.Tags.Select(t => t.TagName).ToList(),
                GameModes = videogame.GameModes.Select(gm => gm.GameModeName).ToList(),
                VideogameUsersCount = videogame.VideogameUsers != null ? videogame.VideogameUsers.Count : 0
            };
        }
        public static VideogameSlimDTO ToSlimDTO(this Videogame videogame)
        {
            return new VideogameSlimDTO
            {
                GameId = videogame.GameId,
                GameName = videogame.GameName,
                ReleaseDate = videogame.ReleaseDate,
                MinPlayers = videogame.MinPlayers,
                MaxPlayers = videogame.MaxPlayers,
                EarlyAccess = videogame.EarlyAccess,
                IsADLC = videogame.DLCOfWhatGameId.HasValue
            };
        }

        public static VideogameDetailsSaveDTO ToDetailsSaveDTO(this Videogame videogame)
        {
            return new VideogameDetailsSaveDTO
            {
                GameName = videogame.GameName,
                ReleaseDate = videogame.ReleaseDate,
                MinPlayers = videogame.MinPlayers,
                MaxPlayers = videogame.MaxPlayers,
                EarlyAccess = videogame.EarlyAccess,
                DLCOfWhatGameId = videogame.DLCOfWhatGameId,
                FromVideogameCollectionId = videogame.FromVideogameCollectionId,
                CollectionOfWhatGamesIds = videogame.CollectionOfWhatGames?.Select(cog => cog.GameId).ToList(),
                DLCsIds = videogame.DLCs?.Select(dlc => dlc.GameId).ToList(),
                GamingPlatformsIds = videogame.GamingPlatforms.Select(gp => gp.PlatformId).ToList(),
                SubscriptionServicesIds = videogame.SubscriptionServices?.Select(ss => ss.SubscriptionServiceId).ToList(),
                DevelopersIds = videogame.Developers.Select(d => d.DeveloperId).ToList(),
                PublishersIds = videogame.Publishers.Select(p => p.PublisherId).ToList(),
                GenresIds = videogame.Genres.Select(g => g.GenreId).ToList(),
                TagsIds = videogame.Tags.Select(t => t.TagId).ToList(),
                GameModesIds = videogame.GameModes.Select(gm => gm.GameModeId).ToList()
            };
        }
}
