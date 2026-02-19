using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.Entities
{
    public class GameMode
    {
        public int GameModeId { get; set; }
        [Required]
        public string GameModeName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; } = new List<Videogame>();

    }
}
