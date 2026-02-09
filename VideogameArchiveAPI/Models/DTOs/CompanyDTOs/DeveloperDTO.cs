using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models.CompanyEntities
{
    public class DeveloperDTO
    {
        [Required]
        public string CompanyName { get; set; }
        public List<VideogameDTO> GameList { get; set; }
    }
}
