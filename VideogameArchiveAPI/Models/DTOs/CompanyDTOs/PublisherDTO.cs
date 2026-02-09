using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models.CompanyEntities
{
    public class PublisherDTO
    {
        [Required]
        public string CompanyName { get; set; }
        public List<VideogameDTO> GameList { get; set; }
        public List<GamingPlatformDTO> GamingConsolesList { get; set; }

    }
}
