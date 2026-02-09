using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.CompanyDTOs
{
    public class PublisherDetailsDTO
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public List<VideogameSlimDTO> GameList { get; set; }
        public List<GamingPlatformSlimDTO> GamingConsolesList { get; set; }

    }
}
