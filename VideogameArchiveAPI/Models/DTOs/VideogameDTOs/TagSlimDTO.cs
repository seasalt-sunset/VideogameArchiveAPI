using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class TagSlimDTO
    {
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
    }
}
