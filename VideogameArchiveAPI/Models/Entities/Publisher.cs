using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.Entities
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        [Required]
        public string PublisherName { get; set; }
        public ICollection<Videogame> GameList { get; set; } = new List<Videogame>();
        public ICollection<GamingPlatform> GamingConsolesList { get; set; } = new List<GamingPlatform>();

    }
}
