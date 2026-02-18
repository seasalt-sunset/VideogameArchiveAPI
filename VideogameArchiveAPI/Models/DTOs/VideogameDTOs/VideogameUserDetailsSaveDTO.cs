using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameUserDetailsSaveDTO
    {
        public int VideogameId { get; set; }
        public string UserId { get; set; }
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
        public string? Notes { get; set; }
        public List<int>? CustomFoldersIds { get; set; }
        public int? ReviewId { get; set; }
        public List<int> VideogameCopiesIds { get; set; }
    }
}
