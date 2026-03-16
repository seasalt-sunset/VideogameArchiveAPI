using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class ReviewMappers
    {
        public static ReviewDTO ToSlimDTO(this Review review)
        {
            return new ReviewDTO
            {
                ReviewId = review.ReviewId,
                Vote = review.Vote,
                ReviewTitle = review.ReviewTitle,
                ReviewContent = review.ReviewContent,
                VideogameUserId = review.VideogameUserId
            };
        }
    }
}
