using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameUserDetailsDTO
    {
        public int VideogameId { get; set; }
        public VideogameSlimDTO Videogame { get; set; }
        public string UserId { get; set; }
        public UserSlimDTO User { get; set; }
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
        public string? Notes { get; set; }
        public List<CustomFolderSlimDTO>? CustomFolders { get; set; }
        public ReviewDTO? Review { get; set; }
        public List<VideogameCopySlimDTO> VideogameCopies { get; set; }
    }
}
