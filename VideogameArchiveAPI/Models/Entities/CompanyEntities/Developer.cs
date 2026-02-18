using System.Collections;
using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities.CompanyEntities
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        [Required]
        public string DeveloperName { get; set; }
        public ICollection<Videogame> GameList { get; set; } = new List<Videogame>();
    }
}
