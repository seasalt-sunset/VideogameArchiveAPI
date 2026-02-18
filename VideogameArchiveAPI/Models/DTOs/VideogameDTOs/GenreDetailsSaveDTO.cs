using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class GenreDetailsSaveDTO
    {
        [Required]
        public string GenreName { get; set; }
        public List<int>? VideogameIdsList { get; set; } = null;

    }
}
