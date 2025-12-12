using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }

    }
}
