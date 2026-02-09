using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class RealOwnerDetailsDTO
    {
        public int RealOwnerId { get; set; }
        public string RealOwnerName { get; set; }

        public string UserId { get; set; }
        public List<VideogameCopySlimDTO> VideogameCopies { get; set; }
    }
}
