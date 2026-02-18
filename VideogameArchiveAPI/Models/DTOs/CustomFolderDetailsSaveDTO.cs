using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class CustomFolderDetailsSaveDTO
    {
        public int FolderId { get; set; }
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public List<int> VideogamesUserIds { get; set; }
        public List<int> VideogameCopiesIds { get; set; }


    }
}
