using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.CompanyDTOs
{
    public class DeveloperDetailsDTO
    {
        [Required]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<VideogameSlimDTO> GameList { get; set; }
    }
}
