using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class CustomFolder
    {
        public int FolderId { get; set; }
        public string FolderName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }


    }
}
