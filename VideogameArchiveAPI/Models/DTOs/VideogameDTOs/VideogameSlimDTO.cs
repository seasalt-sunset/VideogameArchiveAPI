using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameSlimDTO
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

    }
}
