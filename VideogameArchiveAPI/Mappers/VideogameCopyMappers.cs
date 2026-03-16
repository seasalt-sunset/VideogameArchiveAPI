using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class VideogameCopyMappers
    {
        public static VideogameCopyDetailsDTO ToDetailsDTO(this VideogameCopy videogameCopy)
        {
            return new VideogameCopyDetailsDTO
            {
                VideogameCopyId = videogameCopy.VideogameCopyId,
                FromVideogameCollection = videogameCopy.FromVideogameCollection != null ? videogameCopy.FromVideogameCollection.ToSlimDTO() : null,
                HoursPlayed = videogameCopy.HoursPlayed,
                GameStatus = videogameCopy.GameStatus,
                GameOwnership = videogameCopy.GameOwnership,
                GamePriority = videogameCopy.GamePriority,
                GameFormat = videogameCopy.GameFormat,
                GameRegion = videogameCopy.GameRegion,
                SubscriptionService = videogameCopy.SubscriptionService != null ? videogameCopy.SubscriptionService.ToSlimDTO() : null,
                AchievementsObtained = videogameCopy.AchievementsObtained,
                AchievementsTotal = videogameCopy.AchievementsTotal,
                PlayedFrom = videogameCopy.PlayedFrom,
                PlayedTo = videogameCopy.PlayedTo,
                CustomFolders = videogameCopy.CustomFolders != null ? videogameCopy.CustomFolders.Select(cf => cf.ToSlimDTO()).ToList() : null,
                RealOwners = videogameCopy.RealOwners != null ? videogameCopy.RealOwners.Select(ro => ro.ToSlimDTO()).ToList() : null
            };
        }
        public static VideogameCopySlimDTO ToSlimDTO(this VideogameCopy videogameCopy)
        {
            return new VideogameCopySlimDTO
            {
                VideogameCopyId = videogameCopy.VideogameCopyId,
                HoursPlayed = videogameCopy.HoursPlayed,
                GameStatus = videogameCopy.GameStatus,
                GameOwnership = videogameCopy.GameOwnership,
                GamePriority = videogameCopy.GamePriority,
                GameFormat = videogameCopy.GameFormat,
                GameRegion = videogameCopy.GameRegion,
                AchievementsObtained = videogameCopy.AchievementsObtained,
                AchievementsTotal = videogameCopy.AchievementsTotal
            };
        }

        public static VideogameCopyDetailsSaveDTO ToSaveDTO(this VideogameCopy videogameCopy)
        {
            return new VideogameCopyDetailsSaveDTO
            {
                FromVideogameCollectionId = videogameCopy.FromVideogameCollectionId,
                HoursPlayed = videogameCopy.HoursPlayed?.Hours ?? 0,
                MinutesPlayed = videogameCopy.HoursPlayed?.Minutes ?? 0,
                GameStatus = videogameCopy.GameStatus,
                GameOwnership = videogameCopy.GameOwnership,
                GamePriority = videogameCopy.GamePriority,
                GameFormat = videogameCopy.GameFormat,
                GameRegion = videogameCopy.GameRegion,
                SubscriptionServiceId = videogameCopy.SubscriptionService?.SubscriptionServiceId ?? 0,
                AchievementsObtained = videogameCopy.AchievementsObtained,
                AchievementsTotal = videogameCopy.AchievementsTotal,
                PlayedFrom = videogameCopy.PlayedFrom,
                PlayedTo = videogameCopy.PlayedTo,
                CustomFoldersIdsList = videogameCopy.CustomFolders != null ? videogameCopy.CustomFolders.Select(cf => cf.FolderId).ToList() : null,
                RealOwnersIdsList = videogameCopy.RealOwners != null ? videogameCopy.RealOwners.Select(ro => ro.RealOwnerId).ToList() : null
            };
        }
    }
}
