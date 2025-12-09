namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class GameMode
    {
        public int Id { get; set; }
        public string GameModeName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }

    }
}
