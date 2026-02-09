using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GenreDetailsDTO
    {
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public List<VideogameSlimDTO> VideogameList { get; set; }

    }
}
