using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameUserSlimDTO
    {
        public int VideogameId { get; set; }
        public string UserId { get; set; }
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
    }
}
