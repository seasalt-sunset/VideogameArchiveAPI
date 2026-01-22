using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.CompanyModels;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Videogame
    {
        public int GameId { get; set; }

        [Required]
        public string GameName { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; }
        [Required]
        public int MinPlayers { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        public bool EarlyAccess { get; set; } = false;
        public int? DLCOfWhatGameId { get; set; } = null;

        public Videogame? DLCOfWhatGame { get; set; } = null;

        public ICollection<Videogame> DLCs { get; set; }



        public ICollection<GamingPlatform> GamingPlatforms { get; set; }
        public ICollection<SubscriptionService> SubscriptionServices { get; set; }
        public ICollection<Developer> Developers { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<GameMode> GameModes { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<VideogameUser>? VideogameUsers { get; set; }

    }
}
