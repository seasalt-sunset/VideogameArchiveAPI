using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.Entities.CompanyEntities;

namespace VideogameArchiveAPI.Models.Entities.VideogameEntities
{
    public class Videogame
    {
        public int GameId { get; set; }
        [Required]
        [MaxLength(500)]
        public string GameName { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        [Required]
        public int MinPlayers { get; set; } = 1;
        [Required]
        public int MaxPlayers { get; set; } = 1;
        public bool EarlyAccess { get; set; } = false;
        public int? DLCOfWhatGameId { get; set; } = null;

        public Videogame? DLCOfWhatGame { get; set; } = null;

        public int? FromVideogameCollectionId { get; set; } = null;
        public Videogame? FromVideogameCollection { get; set; } = null;
        public ICollection<Videogame>? CollectionOfWhatGames { get; set; } = new List<Videogame>();

        public ICollection<Videogame>? DLCs { get; set; } = new List<Videogame>();
        public ICollection<GamingPlatform> GamingPlatforms { get; set; } = new HashSet<GamingPlatform>();
        public ICollection<SubscriptionService> SubscriptionServices { get; set; } = new HashSet<SubscriptionService>();
        public ICollection<Developer> Developers { get; set; } = new List<Developer>();
        public ICollection<Publisher> Publishers { get; set; } = new List<Publisher>();
        public ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();
        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public ICollection<GameMode> GameModes { get; set; } = new HashSet<GameMode>();
        public ICollection<VideogameUser> VideogameUsers { get; set; } = new HashSet<VideogameUser>();

    }
}
