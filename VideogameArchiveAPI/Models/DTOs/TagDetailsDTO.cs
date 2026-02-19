using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class TagDetailsDTO
    {
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }
    }
}
