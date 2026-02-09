using System.ComponentModel.DataAnnotations;
namespace VideogameArchiveAPI.Models.DTOs
{
    public class ReviewDTO
    {
        public int ReviewId { get; set; }
        public double? Vote { get; set; } = null;
        [Required]
        public string ReviewTitle { get; set; }
        [Required]
        public string ReviewContent { get; set; }

        public int VideogameUserId { get; set; }

    }
}
