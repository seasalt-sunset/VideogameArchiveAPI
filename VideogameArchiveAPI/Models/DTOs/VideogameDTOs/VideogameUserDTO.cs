using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.VideogameEntities
{
    public class VideogameUserDTO
    {
        public VideogameDTO Videogame { get; set; }
        public string UserId { get; set; }
        public UserDTO User { get; set; }
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
        public string? Notes { get; set; }
        public ICollection<CustomFolderDTO>? CustomFolders { get; set; }
        public ReviewDTO? Review { get; set; }
        public ICollection<VideogameCopyDTO> VideogameCopies { get; set; }
    }
}
