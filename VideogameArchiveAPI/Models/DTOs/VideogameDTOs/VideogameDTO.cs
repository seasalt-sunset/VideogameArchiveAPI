using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.CompanyEntities;

namespace VideogameArchiveAPI.Models.VideogameEntities
{
    public class VideogameDTO
    {
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

        public VideogameDTO? DLCOfWhatGame { get; set; } = null;
        public VideogameDTO? FromVideogameCollection { get; set; } = null;
        public ICollection<VideogameDTO>? CollectionOfWhatGames { get; set; }

        public ICollection<VideogameDTO> DLCs { get; set; }
        public ICollection<GamingPlatformDTO> GamingPlatforms { get; set; }
        public ICollection<SubscriptionServiceDTO> SubscriptionServices { get; set; }
        public ICollection<DeveloperDTO> Developers { get; set; }
        public ICollection<PublisherDTO> Publishers { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }
        public ICollection<TagDTO>? Tags { get; set; }
        public ICollection<GameModeDTO> GameModes { get; set; }
        public ICollection<VideogameUserDTO>? VideogameUsers { get; set; }

    }
}
