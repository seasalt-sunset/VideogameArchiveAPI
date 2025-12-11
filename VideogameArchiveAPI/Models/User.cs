using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class User
    {
        public string UserId { get; init; }
        public string UserName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<Videogame> Videogames { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }
    }
}
