using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class UserMappers
    {
        public static UserDetailsDTO ToDetailsDTO(this User user)
        {
            return new UserDetailsDTO
            {
                UserId = user.UserId,
                UserName = user.UserName,
                CreatedAt = DateOnly.FromDateTime(user.CreatedAt.Date),
                VideogamesUser = user.VideogamesUser.Select(vu => vu.ToSlimDTO()).ToList(),
                RealOwners = user.RealOwners.Select(ro => ro.ToSlimDTO()).ToList()
            };
        }
        public static UserSlimDTO ToSlimDTO(this User user)
        {
            return new UserSlimDTO
            {
                UserId = user.UserId,
                UserName = user.UserName
            };
        }

        public static UserDetailsSaveDTO ToSaveDTO(this User user)
        {
            return new UserDetailsSaveDTO
            {
                UserName = user.UserName,
                VideogamesUserIds = user.VideogamesUser.Select(vu => vu.VideogameUserId).ToList(),
                RealOwnersIds = user.RealOwners.Select(ro => ro.RealOwnerId).ToList()
            };
        }
    }
}
