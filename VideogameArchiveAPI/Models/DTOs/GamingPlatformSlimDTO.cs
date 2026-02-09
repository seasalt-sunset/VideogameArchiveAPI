using System.ComponentModel.DataAnnotations;

namespace VideogameArchiveAPI.Models.DTOs
{
    public class GamingPlatformSlimDTO
    {
        public int PlatformId { get; set; }
        [Required]
		public string PlatformName { get; set; }



    }
}
