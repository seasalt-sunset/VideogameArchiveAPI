using VideogameArchiveAPI.Enums;

namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class VideogameUser
    {
        public int VideogameUserId { get; set; }

        public int VideogameId { get; set; }
        public Videogame Videogame { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int FromVideogameCollectionId { get; set; }
        public Videogame? FromVideogameCollection { get; set; }
        public TimeSpan? HoursPlayed { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.Unspecified;
        public GameOwnership GameOwnership { get; set; } = GameOwnership.Unspecified;
        public GamePriority GamePriority { get; set; } = GamePriority.Unspecified;
        public GameFormat GameFormat { get; set; } = GameFormat.Unspecified;
        public GameRegion GameRegion { get; set; } = GameRegion.Unspecified;
        public SubscriptionService SubscriptionService { get; set; } = SubscriptionService.None;
        public bool BetaTested { get; set; } = false;
        public bool Infinite { get; set; } = false;
        public int TimesCompleted { get; set; } = 0;
        public int AchievementsObtained { get; set; } = 0;
        public int AchievementsTotal { get; set; } = 0;
        public string? Notes { get; set; }
        public ICollection<CustomFolder>? CustomFolders { get; set; }
        public Review? Review { get; set; }
    }
}
