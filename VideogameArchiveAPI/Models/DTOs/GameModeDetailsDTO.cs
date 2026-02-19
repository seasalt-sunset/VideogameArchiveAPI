using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GameModeDetailsDTO
    {
        public int GameModeId { get; set; }
        [Required]
        public string GameModeName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }

    }
}
