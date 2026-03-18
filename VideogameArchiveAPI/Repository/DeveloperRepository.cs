using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        DeveloperRepository(VideogameArchiveAPIDbContext db) : base(db)
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
