using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GameModeDetailsSaveDTO
    {
        [Required]
        public string GameModeName { get; set; }
        public List<int>? VideogameIdsList { get; set; } = null;

    }
}
