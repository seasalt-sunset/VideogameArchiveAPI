using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class DeveloperDetailsSaveDTO
    {
        [Required]
        public string DeveloperName { get; set; }
        public List<int>? GameIdsList { get; set; } = null;
    }
}
