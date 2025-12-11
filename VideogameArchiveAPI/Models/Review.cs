using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public double Vote { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }

        public int VideogameUserId { get; set; }
        public VideogameUser VideogameUser { get; set; }

    }
}
