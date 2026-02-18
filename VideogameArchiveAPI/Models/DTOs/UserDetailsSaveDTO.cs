using VideogameArchiveAPI.Models.DTOs.VideogameDTOs;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class UserDetailsSaveDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateOnly CreatedAt { get; set; }
        public List<int> VideogamesUserIds { get; set; }
        public List<int> RealOwnersIds { get; set; }
    }
}
