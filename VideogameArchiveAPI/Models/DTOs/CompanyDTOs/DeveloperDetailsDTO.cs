using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.DeveloperDTOs
{
    public class DeveloperDetailsDTO
    {
        [Required]
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public List<VideogameSlimDTO> GameList { get; set; }
    }
}
