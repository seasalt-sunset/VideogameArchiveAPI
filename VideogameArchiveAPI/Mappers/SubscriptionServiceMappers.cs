using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class SubscriptionServiceMappers
    {
        public static SubscriptionServiceDetailsDTO ToDetailsDTO(this SubscriptionService subscriptionService)
        {
            return new SubscriptionServiceDetailsDTO
            {
                SubscriptionServiceId = subscriptionService.SubscriptionServiceId,
                SubscriptionServiceName = subscriptionService.SubscriptionServiceName,
                Price = subscriptionService.Price,
                Videogames = subscriptionService.Videogames.Select(v => v.ToSlimDTO()).ToList()
            };
        }
        public static SubscriptionServiceSlimDTO ToSlimDTO(this SubscriptionService subscriptionService)
        {
            return new SubscriptionServiceSlimDTO
            {
                SubscriptionServiceId = subscriptionService.SubscriptionServiceId,
                SubscriptionServiceName = subscriptionService.SubscriptionServiceName
            };
        }

        public static SubscriptionServiceDetailsSaveDTO ToSaveDTO(this SubscriptionService subscriptionService)
        {
            return new SubscriptionServiceDetailsSaveDTO
            {
                SubscriptionServiceName = subscriptionService.SubscriptionServiceName,
                Price = subscriptionService.Price,
                VideogamesIds = subscriptionService.Videogames.Select(v => v.GameId).ToList()
            };
        }
    }
}
