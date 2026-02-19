using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.SlimDTOs
{
    public class GameModeSlimDTO
    {
        public int GameModeId { get; set; }
        [Required]
        public string GameModeName { get; set; }

    }
}
