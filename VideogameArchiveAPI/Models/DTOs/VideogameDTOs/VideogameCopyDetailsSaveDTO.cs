using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.DTOs;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameCopyDetailsSaveDTO
    {
        public VideogameSlimDTO? FromVideogameCollection { get; set; }
        public int HoursPlayed { get; set; }
        public int MinutesPlayed { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.Unspecified;
        public GameOwnership GameOwnership { get; set; } = GameOwnership.Unspecified;
        public GamePriority GamePriority { get; set; } = GamePriority.Unspecified;
        public GameFormat GameFormat { get; set; } = GameFormat.Unspecified;
        public GameRegion GameRegion { get; set; } = GameRegion.Unspecified;
        public int? SubscriptionServiceId { get; set; }
        public int AchievementsObtained { get; set; } = 0;
        public int AchievementsTotal { get; set; } = 0;
        public DateOnly? PlayedFrom { get; set; }
        public DateOnly? PlayedTo { get; set; }
        public List<int>? CustomFoldersIdsList { get; set; }
        public List<int>? RealOwnersIdsList { get; set; }

    }
}
