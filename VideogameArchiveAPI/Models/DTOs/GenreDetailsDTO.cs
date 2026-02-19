using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GenreDetailsDTO
    {
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }

    }
}
