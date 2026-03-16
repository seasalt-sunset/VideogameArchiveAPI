using VideogameArchiveAPI.Models.DTOs;
using VideogameArchiveAPI.Models.DTOs.SlimDTOs;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Models.DTOs.CreateUpdateDTOs;

namespace VideogameArchiveAPI.Mappers
{
    public static class GenreMappers
    {
        public static GenreDetailsDTO ToDetailsDTO(this Genre genre)
        {
            return new GenreDetailsDTO
            {
                GenreId = genre.GenreId,
                GenreName = genre.GenreName,
                VideogameList = genre.VideogameList.Select(v => v.ToSlimDTO()).ToList()
            };
        }
        public static GenreSlimDTO ToSlimDTO(this Genre genre)
        {
            return new GenreSlimDTO
            {
                GenreId = genre.GenreId,
                GenreName = genre.GenreName
            };
        }

        public static GenreDetailsSaveDTO ToSaveDTO(this Genre genre)
        {
            return new GenreDetailsSaveDTO
            {
                GenreName = genre.GenreName,
                VideogameIdsList = genre.VideogameList.Select(v => v.GameId).ToList()
            };
        }
    }
}
