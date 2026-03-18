using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class CustomFolderRepository : GenericRepository<CustomFolder>, ICustomFolderRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        CustomFolderRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(CustomFolder entity)
        {
            _db.CustomFolders.Update(entity);
            await SaveChangesAsync();
        }
    }
}
