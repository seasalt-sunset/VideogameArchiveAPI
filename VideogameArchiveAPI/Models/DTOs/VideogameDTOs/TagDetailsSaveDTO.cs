using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class TagDetailsSaveDTO
    {
        [Required]
        public string TagName { get; set; }
        public List<int>? VideogameIdList { get; set; } = null;
    }
}
