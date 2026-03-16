using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class CustomFolderDetailsSaveDTO
    {
        [Required]
        public string FolderName { get; set; } = $"New Collection - {DateTimeOffset.Now}";
        public List<int> VideogamesUserIds { get; set; }
        public List<int> VideogameCopyIds { get; set; }


    }
}
