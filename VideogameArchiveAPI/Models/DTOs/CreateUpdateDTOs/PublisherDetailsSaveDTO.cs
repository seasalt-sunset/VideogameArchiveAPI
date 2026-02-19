using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class PublisherDetailsSaveDTO
    {
        [Required]
        public string PublisherName { get; set; }
        public List<int>? GameIdsList { get; set; } = null;
        public List<int>? GamingConsolesIdsList { get; set; } = null;

    }
}
