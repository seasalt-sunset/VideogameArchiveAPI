using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.CompanyModels;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class GamingPlatform
    {
        public int ConsoleId { get; set; }
        [Required]
		public string ConsoleName { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }



    }
}
