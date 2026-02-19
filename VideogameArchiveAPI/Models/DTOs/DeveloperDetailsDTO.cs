using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class DeveloperDetailsDTO
    {
        [Required]
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public List<VideogameSlimDTO> GameList { get; set; }
    }
}
