using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models.CompanyModels
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
