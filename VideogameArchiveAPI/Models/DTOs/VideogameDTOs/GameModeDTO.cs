using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.VideogameEntities
{
    public class GameModeDTO
    {
        [Required]
        public string GameModeName { get; set; }
        public ICollection<VideogameDTO> VideogameList { get; set; }

    }
}
