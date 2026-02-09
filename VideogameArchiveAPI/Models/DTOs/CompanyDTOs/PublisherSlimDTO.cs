using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CompanyDTOs
{
    public class PublisherSlimDTO
    {
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }

    }
}
