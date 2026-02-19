using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class GameModeDetailsSaveDTO
    {
        [Required]
        public string GameModeName { get; set; }
        public List<int>? VideogameIdsList { get; set; } = null;

    }
}
