using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class RealOwnerDetailsSaveDTO
    {
        public int RealOwnerId { get; set; }
        public string RealOwnerName { get; set; }

        public string UserId { get; set; }
        public List<int>? VideogameCopiesIds { get; set; }
    }
}
