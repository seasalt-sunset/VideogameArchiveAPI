using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class TagDetailsSaveDTO
    {
        [Required]
        public string TagName { get; set; }
        public List<int>? VideogameIdsList { get; set; } = null;
    }
}
