using System.ComponentModel.DataAnnotations;
namespace VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs
{
    public class GamingPlatformDetailsSaveDTO
    {
        [Required]
		public string PlatformName { get; set; }
        [Required]
        public DateOnly? ReleaseDate { get; set; }
        public int? PublisherId { get; set; }
        public List<int>? VideogameListIds { get; set; }



    }
}
