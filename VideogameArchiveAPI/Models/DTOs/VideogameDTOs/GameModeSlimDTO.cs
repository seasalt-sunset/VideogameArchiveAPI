using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GameModeSlimDTO
    {
        public int GameModeId { get; set; }
        [Required]
        public string GameModeName { get; set; }

    }
}
