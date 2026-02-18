using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Enums;
using VideogameArchiveAPI.Models.DTOs.CompanyDTOs;

namespace VideogameArchiveAPI.Models.DTOs.VideogameDTOs
{
    public class VideogameDetailsSaveDTO
    {
        public int GameId { get; set; }
        [Required]
        [MaxLength(500)]
        public string GameName { get; set; }
        [Required]
        public DateOnly ReleaseDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        [Required]
        public int MinPlayers { get; set; } = 1;
        [Required]
        public int MaxPlayers { get; set; } = 1;
        public bool EarlyAccess { get; set; } = false;

        public int? DLCOfWhatGameId { get; set; } = null;
        public int? FromVideogameCollectionId { get; set; } = null;
        public List<int>? CollectionOfWhatGameIds { get; set; } = null;

        public List<int>? DLCsIds { get; set; } = null;
        public List<int> GamingPlatformsIds { get; set; } 
        public List<int> SubscriptionServicesIds { get; set; }
        public List<int> DevelopersIds { get; set; }
        public List<int> PublishersIds { get; set; }
        public List<int> GenresIds { get; set; }
        public List<int>? TagsIds { get; set; }
        public List<int> GameModesIds { get; set; }
        public List<int>? VideogameUsersIds { get; set; }

    }
}
