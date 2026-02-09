using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUserDTO> VideogamesUser { get; set; }
        public ICollection<RealOwnerDTO> RealOwners { get; set; }
    }
}
