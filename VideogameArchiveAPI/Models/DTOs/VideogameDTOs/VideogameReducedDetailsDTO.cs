using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameReducedDetailsDTO
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

        public bool IsADLC { get; set; }
        public List<string> GamingPlatforms { get; set; }
        public List<string> Developers { get; set; }
        public List<string> Publishers { get; set; }
        public List<string> Genres { get; set; }
        public List<string>? Tags { get; set; }
        public List<string> GameModes { get; set; }
        public List<string>? VideogameUsers { get; set; }

    }
}
