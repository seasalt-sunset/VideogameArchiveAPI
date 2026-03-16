using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class GameModeMappers
    {
        public static GameModeDetailsDTO ToDetailsDTO(this GameMode gameMode)
        {
            return new GameModeDetailsDTO
            {
                GameModeId = gameMode.GameModeId,
                GameModeName = gameMode.GameModeName,
                VideogameList = gameMode.VideogameList.Select(v => v.ToSlimDTO()).ToList()
            };
        }

        public static GameModeSlimDTO ToSlimDTO(this GameMode gameMode)
        {
            return new GameModeSlimDTO
            {
                GameModeId = gameMode.GameModeId,
                GameModeName = gameMode.GameModeName
            };
        }

        public static GameModeDetailsSaveDTO ToSaveDTO(this GameMode gameMode)
        {
            return new GameModeDetailsSaveDTO
            {
                GameModeName = gameMode.GameModeName,
                VideogameIdsList = gameMode.VideogameList.Select(v => v.GameId).ToList()
            };
        }
    }
}
