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
        public ICollection<Videogame>? CollectionOfWhatGames { get; set; }

        public ICollection<Videogame> DLCs { get; set; }
        public ICollection<GamingPlatform> GamingPlatforms { get; set; }
        public ICollection<SubscriptionService> SubscriptionServices { get; set; }
        public ICollection<Developer> Developers { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<GameMode> GameModes { get; set; }
        public ICollection<VideogameUser>? VideogameUsers { get; set; }

    }
}
