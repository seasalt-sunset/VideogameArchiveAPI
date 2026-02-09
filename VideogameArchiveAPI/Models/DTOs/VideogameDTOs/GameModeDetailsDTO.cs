using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GameModeDetailsDTO
    {
        public int GameModeId { get; set; }
        [Required]
        public string GameModeName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }

    }
}
