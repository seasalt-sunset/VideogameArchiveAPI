using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.VideogameEntities
{
    public class TagDTO
    {
        [Required]
        public string TagName { get; set; }
        public ICollection<VideogameDTO> VideogameList { get; set; }
    }
}
