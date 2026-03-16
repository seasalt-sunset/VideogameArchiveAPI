using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class TagMappers
    {
        public static TagDetailsDTO ToDetailsDTO(this Tag tag)
        {
            return new TagDetailsDTO
            {
                TagId = tag.TagId,
                TagName = tag.TagName,
                VideogameList = tag.VideogameList.Select(v => v.ToSlimDTO()).ToList()
            };
        }

        public static TagSlimDTO ToSlimDTO(this Tag tag)
        {
            return new TagSlimDTO
            {
                TagId = tag.TagId,
                TagName = tag.TagName
            };
        }

        public static TagDetailsSaveDTO ToSaveDTO(this Tag tag)
        {
            return new TagDetailsSaveDTO
            {
                TagName = tag.TagName,
                VideogameIdsList = tag.VideogameList.Select(v => v.GameId).ToList()
            };
        }
    }
}
