using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameCopySlimDTO
    {
        public int VideogameCopyId { get; set; }
        public TimeSpan? HoursPlayed { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.Unspecified;
        public GameOwnership GameOwnership { get; set; } = GameOwnership.Unspecified;
        public GamePriority GamePriority { get; set; } = GamePriority.Unspecified;
        public GameFormat GameFormat { get; set; } = GameFormat.Unspecified;
        public GameRegion GameRegion { get; set; } = GameRegion.Unspecified;
        public int AchievementsObtained { get; set; } = 0;
        public int AchievementsTotal { get; set; } = 0;

    }
}
