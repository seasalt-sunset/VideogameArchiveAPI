using VideogameArchiveAPI.Models.CompanyModels;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class GamingConsole
    {
        public int ConsoleId { get; set; }
		public string ConsoleName { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }



    }
}
