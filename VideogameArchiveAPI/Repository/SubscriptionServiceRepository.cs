using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class SubscriptionServiceRepository : GenericRepository<SubscriptionService>, ISubscriptionServiceRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        SubscriptionServiceRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(SubscriptionService entity)
        {
            _db.SubscriptionServices.Update(entity);
            await SaveChangesAsync();
        }
    }
}
