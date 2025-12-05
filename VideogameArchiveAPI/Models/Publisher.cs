
namespace VideogameArchiveAPI.Models
{
    public class Publisher : Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<Videogame> GameList { get; set; }
    }
}
