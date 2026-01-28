using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class VideogameCopy
    {
        public int VideogameCopyId { get; set; }
        public int VideogameUserId { get; set; }
        public int FromVideogameCollectionId { get; set; }
        public Videogame? FromVideogameCollection { get; set; }
        public TimeSpan? HoursPlayed { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.Unspecified;
        public GameOwnership GameOwnership { get; set; } = GameOwnership.Unspecified;
        public GamePriority GamePriority { get; set; } = GamePriority.Unspecified;
        public GameFormat GameFormat { get; set; } = GameFormat.Unspecified;
        public GameRegion GameRegion { get; set; } = GameRegion.Unspecified;
        public SubscriptionService SubscriptionService { get; set; }
        public int AchievementsObtained { get; set; } = 0;
        public int AchievementsTotal { get; set; } = 0;
        public DateOnly? PlayedFrom { get; set; }
        public DateOnly? PlayedTo { get; set; }
        public ICollection<CustomFolder>? CustomFolders { get; set; }
        public ICollection<RealOwner>? RealOwners { get; set; }

    }
}
