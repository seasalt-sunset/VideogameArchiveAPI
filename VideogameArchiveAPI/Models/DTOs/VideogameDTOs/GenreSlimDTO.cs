using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GenreSlimDTO
    {
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }

    }
}
