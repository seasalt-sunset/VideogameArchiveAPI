using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models.CompanyModels
{
    public class Developer : Company
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public List<Videogame> GameList { get; set; }
    }
}
