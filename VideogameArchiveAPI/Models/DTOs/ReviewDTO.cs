using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameEntities;

namespace VideogameArchiveAPI.Models
{
    public class ReviewDTO
    {
        public double? Vote { get; set; } = null;
        [Required]
        public string ReviewTitle { get; set; }
        [Required]
        public string ReviewContent { get; set; }

        public int VideogameUserId { get; set; }

    }
}
