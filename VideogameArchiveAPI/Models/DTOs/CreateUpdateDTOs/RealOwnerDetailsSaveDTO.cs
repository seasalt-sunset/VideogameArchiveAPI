namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class RealOwnerDetailsSaveDTO
    {
        public string RealOwnerName { get; set; }

        public string UserId { get; set; }
        public List<int>? VideogameCopiesIds { get; set; }
    }
}
