using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.CompanyModels;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Videogame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public bool EarlyAccess { get; set; }

        public ICollection<GamingConsole> GamingConsoles { get; set; }
        public ICollection<Developer> Developers { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<GameMode> GameModes { get; set; }
    }
}
