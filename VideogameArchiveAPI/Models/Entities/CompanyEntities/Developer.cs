using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities.CompanyEntities
{
    public class Developer : Company
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public List<Videogame> GameList { get; set; }
    }
}
