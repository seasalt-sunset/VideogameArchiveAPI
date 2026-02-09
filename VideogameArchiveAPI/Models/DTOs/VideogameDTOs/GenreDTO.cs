using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.VideogameEntities
{
    public class GenreDTO
    {
        [Required]
        public string GenreName { get; set; }
        public ICollection<VideogameDTO> VideogameList { get; set; }

    }
}
