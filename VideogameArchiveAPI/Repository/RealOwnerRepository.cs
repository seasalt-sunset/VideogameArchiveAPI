using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class RealOwnerRepository : GenericRepository<RealOwner>, IRealOwnerRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        RealOwnerRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(RealOwner entity)
        {
            _db.RealOwners.Update(entity);
            await SaveChangesAsync();
        }
    }
}
