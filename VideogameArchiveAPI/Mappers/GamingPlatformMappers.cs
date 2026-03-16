using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class GamingPlatformMappers
    {
        public static GamingPlatformDetailsDTO ToDetailsDTO(this GamingPlatform dto)
        {
            return new GamingPlatformDetailsDTO
            {
                PlatformId = dto.PlatformId,
                PlatformName = dto.PlatformName,
                ReleaseDate = dto.ReleaseDate,
                Publisher = dto.Publisher != null ? dto.Publisher.ToSlimDTO() : null,
                VideogameList = dto.VideogameList.Select(v => v.ToSlimDTO()).ToList()
            };
        }
        public static GamingPlatformSlimDTO ToSlimDTO(this GamingPlatform gamingPlatform)
        {
            return new GamingPlatformSlimDTO
            {
                PlatformId = gamingPlatform.PlatformId,
                PlatformName = gamingPlatform.PlatformName
            };
        }

        public static GamingPlatformDetailsSaveDTO ToSaveDTO(this GamingPlatform gamingPlatform)
        {
            return new GamingPlatformDetailsSaveDTO
            {
                PlatformName = gamingPlatform.PlatformName,
                ReleaseDate = gamingPlatform.ReleaseDate,
                PublisherId = gamingPlatform.PublisherId,
                VideogameListIds = gamingPlatform.VideogameList.Select(v => v.GameId).ToList()
            };
        }
    }
}
