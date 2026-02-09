using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.Entities.VideogameEntities;

namespace VideogameArchiveAPI.Models.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public double? Vote { get; set; } = null;
        [Required]
        public string ReviewTitle { get; set; }
        [Required]
        public string ReviewContent { get; set; }

        public int VideogameUserId { get; set; }
        public VideogameUser VideogameUser { get; set; }

    }
}
