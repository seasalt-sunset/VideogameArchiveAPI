using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.CompanyEntities;
using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models
{
    public class GamingPlatformDTO
    {
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public PublisherDTO? Publisher { get; set; }
        public ICollection<VideogameDTO> VideogameList { get; set; }



    }
}
