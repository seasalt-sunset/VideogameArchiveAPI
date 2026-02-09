using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class UserDetailsDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateOnly CreatedAt { get; set; }
        public List<VideogameUserSlimDTO> VideogamesUser { get; set; }
        public List<RealOwnerSlimDTO> RealOwners { get; set; }
    }
}
