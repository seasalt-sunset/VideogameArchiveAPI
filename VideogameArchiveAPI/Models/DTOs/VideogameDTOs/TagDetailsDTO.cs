using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class TagDetailsDTO
    {
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }
    }
}
