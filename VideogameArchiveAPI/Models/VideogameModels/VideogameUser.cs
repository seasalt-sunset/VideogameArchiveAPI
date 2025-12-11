using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class VideogameUser
    {
        public int VideogameUserId { get; set; }

        public int VideogameId { get; set; }
        public Videogame Videogame { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public GameStatus GameStatus { get; set; }
        public Ownership Ownership { get; set; }
        public TimeSpan HoursPlayed { get; set; }
        public bool BetaTested { get; set; } = false;
        public int TimesCompleted { get; set; }
        public ICollection<CustomFolder> CustomFolders { get; set; }
        public Review Reviews { get; set; }
    }
}
