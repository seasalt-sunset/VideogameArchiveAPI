using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.CompanyDTOs
{
    public class DeveloperDetailsSaveDTO
    {
        [Required]
        public string DeveloperName { get; set; }
        public List<int>? GameIdsList { get; set; } = null;
    }
}
