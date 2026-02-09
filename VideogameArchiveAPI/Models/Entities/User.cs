using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities
{
    public class User
    {
        public string UserId { get; init; }
        public string UserName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }
        public ICollection<RealOwner> RealOwners { get; set; }
    }
}
