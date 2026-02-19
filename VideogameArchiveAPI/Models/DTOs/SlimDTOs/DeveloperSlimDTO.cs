using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.SlimDTOs
{
    public class DeveloperSlimDTO
    {
        public int DeveloperId { get; set; }
        [Required]
        public string DeveloperName { get; set; }
    }
}
