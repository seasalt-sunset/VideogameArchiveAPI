using VideogameArchiveAPI.Models.Entities;

namespace VideogameArchiveAPI.Repository.Interfaces
{
    public interface ICustomFolderRepository : IGenericRepository<CustomFolder>
    {
        public Task UpdateAsync(CustomFolder entity);
    }
}
