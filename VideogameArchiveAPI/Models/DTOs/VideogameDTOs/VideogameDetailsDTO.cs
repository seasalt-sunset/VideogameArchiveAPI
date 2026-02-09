using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.DTOs.CompanyDTOs;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameDetailsDTO
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

        public VideogameSlimDTO? DLCOfWhatGame { get; set; } = null;
        public VideogameSlimDTO? FromVideogameCollection { get; set; } = null;
        public List<VideogameSlimDTO>? CollectionOfWhatGames { get; set; } = null;

        public List<VideogameSlimDTO>? DLCs { get; set; } = null;
        public List<GamingPlatformSlimDTO> GamingPlatforms { get; set; } 
        public List<SubscriptionServiceSlimDTO> SubscriptionServices { get; set; }
        public List<DeveloperSlimDTO> Developers { get; set; }
        public List<PublisherDetailsDTO> Publishers { get; set; }
        public List<GenreSlimDTO> Genres { get; set; }
        public List<TagSlimDTO>? Tags { get; set; }
        public List<GameModeSlimDTO> GameModes { get; set; }
        public List<VideogameUserSlimDTO>? VideogameUsers { get; set; }

    }
}
