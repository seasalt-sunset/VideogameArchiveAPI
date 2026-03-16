namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class UserDetailsSaveDTO
    {
        public string UserName { get; set; }
        public List<int> VideogamesUserIds { get; set; }
        public List<int> RealOwnersIds { get; set; }
    }
}
