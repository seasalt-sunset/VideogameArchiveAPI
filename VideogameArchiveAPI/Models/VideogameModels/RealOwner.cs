namespace VideogameArchiveAPI.Models.VideogameModels
{
    public class RealOwner
    {
        public int RealOwnerId { get; set; }
        public string RealOwnerName { get; set; }
        public ICollection<VideogameCopy> VideogameCopies { get; set; }
    }
}
