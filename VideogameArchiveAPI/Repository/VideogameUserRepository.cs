using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class VideogameUserRepository : GenericRepository<VideogameUser>, IVideogameUserRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        VideogameUserRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(VideogameUser entity)
        {
            _db.VideogameUsers.Update(entity);
            await SaveChangesAsync();
        }
    }
}
