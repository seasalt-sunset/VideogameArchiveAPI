using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.CompanyDTOs;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GamingPlatformDetailsSaveDTO
    {
        public int PlatformId { get; set; }
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public int? PublisherId { get; set; }
        public List<int>? VideogameListIds { get; set; }



    }
}
