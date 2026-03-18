using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class GamingPlatformRepository : GenericRepository<GamingPlatform>, IGamingPlatformRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        GamingPlatformRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(GamingPlatform entity)
        {
            _db.GamingPlatforms.Update(entity);
            await SaveChangesAsync();
        }
    }
}
