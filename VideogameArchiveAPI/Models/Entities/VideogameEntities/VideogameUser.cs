using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.Entities;

namespace VideogameArchiveAPI.Models.Entities.VideogameEntities
{
    public class VideogameUser
    {
        public int VideogameUserId { get; set; }
        public int VideogameId { get; set; }
        public Videogame Videogame { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
        public string? Notes { get; set; }
        public ICollection<CustomFolder> CustomFolders { get; set; } = new List<CustomFolder>();
        public Review? Review { get; set; }
        public ICollection<VideogameCopy> VideogameCopies { get; set; } = new HashSet<VideogameCopy>();
    }
}
