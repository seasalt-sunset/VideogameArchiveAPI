namespace VideogameArchiveAPI.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }

    }
}
