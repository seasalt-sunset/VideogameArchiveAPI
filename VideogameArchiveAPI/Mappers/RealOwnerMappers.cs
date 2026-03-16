using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class RealOwnerMappers
    {
        public static RealOwnerDetailsDTO ToDetailsDTO(this RealOwner realOwner)
        {
            return new RealOwnerDetailsDTO
            {
                RealOwnerId = realOwner.RealOwnerId,
                RealOwnerName = realOwner.RealOwnerName,
                UserId = realOwner.UserId,
                VideogameCopies = realOwner.VideogameCopies.Select(vc => vc.ToSlimDTO()).ToList()
            };
        }

        public static RealOwnerSlimDTO ToSlimDTO(this RealOwner realOwner)
        {
            return new RealOwnerSlimDTO
            {
                RealOwnerId = realOwner.RealOwnerId,
                RealOwnerName = realOwner.RealOwnerName
            };
        }

        public static RealOwnerDetailsSaveDTO ToSaveDTO(this RealOwner realOwner)
        {
            return new RealOwnerDetailsSaveDTO
            {
                RealOwnerName = realOwner.RealOwnerName,
                UserId = realOwner.UserId,
                VideogameCopiesIds = realOwner.VideogameCopies.Select(vc => vc.VideogameCopyId).ToList()
            };
        }
    }
}
