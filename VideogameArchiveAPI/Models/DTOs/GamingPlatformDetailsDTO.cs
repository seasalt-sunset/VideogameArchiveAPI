using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GamingPlatformDetailsDTO
    {
        public int PlatformId { get; set; }
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public PublisherSlimDTO? Publisher { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }



    }
}
