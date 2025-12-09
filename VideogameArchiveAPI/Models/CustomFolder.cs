using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class CustomFolder
    {
        public int FolderId { get; set; }
        public string FolderName { get; set; }
        public ICollection<Videogame> Videogames { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<VideogameUser> VideogamesUser { get; set; }


    }
}
