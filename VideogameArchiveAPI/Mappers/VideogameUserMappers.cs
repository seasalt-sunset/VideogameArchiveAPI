using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class VideogameUserMappers
    {
        public static VideogameUserDetailsDTO ToDetailsDTO(this VideogameUser videogameUser)
        {
            return new VideogameUserDetailsDTO
            {
                VideogameId = videogameUser.VideogameId,
                Videogame = videogameUser.Videogame.ToSlimDTO(),
                UserId = videogameUser.UserId,
                User = videogameUser.User.ToSlimDTO(),
                BetaTested = videogameUser.BetaTested,
                Infinite = videogameUser.Infinite,
                TimesCompleted = videogameUser.TimesCompleted,
                Notes = videogameUser.Notes,
                CustomFolders = videogameUser.CustomFolders != null ? videogameUser.CustomFolders.Select(cf => cf.ToSlimDTO()).ToList() : null,
                Review = videogameUser.Review != null ? videogameUser.Review.ToSlimDTO() : null,
                VideogameCopies = videogameUser.VideogameCopies.Select(vc => vc.ToSlimDTO()).ToList()
            };
        }
        public static VideogameUserSlimDTO ToSlimDTO(this VideogameUser videogameUser)
        {
            return new VideogameUserSlimDTO
            {
                VideogameId = videogameUser.VideogameId,
                UserId = videogameUser.UserId,
                BetaTested = videogameUser.BetaTested,
                Infinite = videogameUser.Infinite,
                TimesCompleted = videogameUser.TimesCompleted
            };
        }

        public static VideogameUserDetailsSaveDTO ToSaveDTO(this VideogameUser videogameUser)
        {
            return new VideogameUserDetailsSaveDTO
            {
                VideogameId = videogameUser.VideogameId,
                UserId = videogameUser.UserId,
                BetaTested = videogameUser.BetaTested,
                Infinite = videogameUser.Infinite,
                TimesCompleted = videogameUser.TimesCompleted,
                Notes = videogameUser.Notes,
                CustomFoldersIds = videogameUser.CustomFolders?.Select(cf => cf.FolderId).ToList(),
                ReviewId = videogameUser.Review?.ReviewId,
                VideogameCopiesIds = videogameUser.VideogameCopies?.Select(vc => vc.VideogameCopyId).ToList()
            };
        }
    }
}
