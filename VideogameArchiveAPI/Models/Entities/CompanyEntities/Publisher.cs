using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities.CompanyEntities
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
