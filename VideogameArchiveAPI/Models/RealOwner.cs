using VideogameArchiveAPI.Models.VideogameModels;

namespace VideogameArchiveAPI.Models
{
    public class RealOwner
    {
        public int RealOwnerId { get; set; }
        public string RealOwnerName { get; set; }

        public string UserId { get; set; }
        public ICollection<VideogameCopy> VideogameCopies { get; set; }
    }
}
