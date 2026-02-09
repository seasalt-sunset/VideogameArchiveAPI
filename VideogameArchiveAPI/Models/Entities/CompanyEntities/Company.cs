using System.ComponentModel.DataAnnotations.Schema;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities.CompanyEntities
{
    public abstract class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<Videogame> GameList { get; set; }
    }
}
