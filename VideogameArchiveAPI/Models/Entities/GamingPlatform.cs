using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities.CompanyEntities;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities
{
    public class GamingPlatform
    {
        public int PlatformId { get; set; }
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public int? PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<Videogame> VideogameList { get; set; } = new List<Videogame>();



    }
}
