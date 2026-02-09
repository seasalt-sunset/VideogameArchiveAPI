using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models
{
    public class RealOwnerDTO
    {
        public string RealOwnerName { get; set; }

        public string UserId { get; set; }
        public ICollection<VideogameCopyDTO> VideogameCopies { get; set; }
    }
}
