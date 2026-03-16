using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
namespace VideogameArchiveAPI.Mappers
{
    public static class CustomFolderMappers
    {
        public static CustomFolderDetailsDTO ToDetailsDTO(this CustomFolder customFolder)
        {
            return new CustomFolderDetailsDTO
            {
                FolderId = customFolder.FolderId,
                FolderName = customFolder.FolderName,
                VideogamesUser = customFolder.VideogamesUser.Select(vu => vu.ToSlimDTO()).ToList(),
                VideogameCopies = customFolder.VideogameCopies.Select(vc => vc.ToSlimDTO()).ToList()
            };
        }
        public static CustomFolderSlimDTO ToSlimDTO(this CustomFolder customFolder)
        {
            return new CustomFolderSlimDTO
            {
                FolderId = customFolder.FolderId,
                FolderName = customFolder.FolderName
            };
        }

        public static CustomFolderDetailsSaveDTO ToSaveDTO(this CustomFolder customFolder)
        {
            return new CustomFolderDetailsSaveDTO
            {
                FolderName = customFolder.FolderName,
                VideogamesUserIds = customFolder.VideogamesUser.Select(vu => vu.VideogameUserId).ToList(),
                VideogameCopyIds = customFolder.VideogameCopies.Select(vc => vc.VideogameCopyId).ToList()
            };
        }

        public static CustomFolder ToEntity(this CustomFolderDetailsSaveDTO customFolderSaveDTO)
        {
            return new CustomFolder
            {
                FolderName = customFolderSaveDTO.FolderName,
                VideogamesUser = customFolderSaveDTO.VideogamesUserIds.Select(id => new VideogameUser { VideogameUserId = id }).ToList(),
                VideogameCopies = customFolderSaveDTO.VideogameCopyIds.Select(id => new VideogameCopy { VideogameCopyId = id }).ToList()
            };
        }
    }
}
