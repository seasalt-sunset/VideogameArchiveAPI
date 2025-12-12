using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class Tag
    {
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }
        public ICollection<Videogame> VideogameList { get; set; }
    }
}
