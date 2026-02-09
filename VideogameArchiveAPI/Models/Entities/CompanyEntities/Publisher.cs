using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities.CompanyEntities
{
    public class Publisher : Company
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public List<Videogame> GameList { get; set; }
        public List<GamingPlatform> GamingConsolesList { get; set; }

    }
}
