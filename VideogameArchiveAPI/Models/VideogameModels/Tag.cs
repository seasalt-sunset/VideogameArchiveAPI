namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }
    }
}
