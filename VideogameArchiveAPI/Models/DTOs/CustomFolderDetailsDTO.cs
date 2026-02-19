using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class CustomFolderDetailsDTO
    {
        public int FolderId { get; set; }
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public List<VideogameUserSlimDTO> VideogamesUser { get; set; }
        public List<VideogameCopySlimDTO> VideogameCopies { get; set; }


    }
}
