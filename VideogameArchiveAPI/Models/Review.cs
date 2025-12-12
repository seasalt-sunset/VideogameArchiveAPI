using System.ComponentModel.DataAnnotations;
using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public double Vote { get; set; }
        [Required]
        public string ReviewTitle { get; set; }
        [Required]
        public string ReviewContent { get; set; }

        public int VideogameUserId { get; set; }
        public VideogameUser VideogameUser { get; set; }

    }
}
