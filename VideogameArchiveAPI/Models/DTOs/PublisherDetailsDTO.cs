using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class PublisherDetailsDTO
    {
        public int PublisherId { get; set; }
        [Required]
        public string PublisherName { get; set; }
        public List<VideogameSlimDTO> GameList { get; set; }
        public List<GamingPlatformSlimDTO> GamingConsolesList { get; set; }

    }
}
