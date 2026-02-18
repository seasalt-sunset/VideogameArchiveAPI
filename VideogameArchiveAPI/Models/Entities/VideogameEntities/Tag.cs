using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.Entities.VideogameEntities
{
    public class Tag
    {
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; } = new List<Videogame>();
    }
}
