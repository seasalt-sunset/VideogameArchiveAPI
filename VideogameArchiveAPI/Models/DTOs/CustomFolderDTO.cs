using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models
{
    public class CustomFolderDTO
    {
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUserDTO> VideogamesUser { get; set; }
        public ICollection<VideogameCopyDTO> VideogameCopies { get; set; }


    }
}
