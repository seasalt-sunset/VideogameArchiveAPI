using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models
{
    public class VideogameUser
    {
        public int VideogameId { get; set; }
        public Videogame Videogame { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public GameStatus GameStatus { get; set; }
        public TimeSpan HoursPlayed { get; set; }
        public bool BetaTested { get; set; } = false;
        public int TimesCompleted { get; set; }

        public ICollection<CustomFolder> CustomFolders { get; set; }


    }
}
