using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class VideogameCopyRepository : GenericRepository<VideogameCopy>, IVideogameCopyRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        VideogameCopyRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(VideogameCopy entity)
        {
            _db.VideogameCopies.Update(entity);
            await SaveChangesAsync();
        }
    }
}
