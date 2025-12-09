namespace VideogameArchiveAPI.Models
{
    public class Console
    {
        public int ConsoleId { get; set; }
		public string ConsoleName { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }



    }
}
