using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class CustomFolderSlimDTO
    {
        public int FolderId { get; set; }
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";


    }
}
