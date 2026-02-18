using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CompanyDTOs
{
    public class PublisherSlimDTO
    {
        public int PublisherId { get; set; }
        [Required]
        public string PublisherName { get; set; }

    }
}
