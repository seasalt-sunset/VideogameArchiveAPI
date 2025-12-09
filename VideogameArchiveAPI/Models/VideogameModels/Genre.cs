namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }

    }
}
