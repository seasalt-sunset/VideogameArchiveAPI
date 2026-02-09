using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities
{
    public class CustomFolder
    {
        public int FolderId { get; set; }
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }
        public ICollection<VideogameCopy> VideogameCopies { get; set; }


    }
}
