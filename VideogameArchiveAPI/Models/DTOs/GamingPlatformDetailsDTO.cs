using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.CompanyDTOs;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GamingPlatformDetailsDTO
    {
        public int PlatformId { get; set; }
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public PublisherDetailsDTO? Publisher { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }



    }
}
