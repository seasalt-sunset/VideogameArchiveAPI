using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class CustomFolder
    {
        public int FolderId { get; set; }
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }


    }
}
