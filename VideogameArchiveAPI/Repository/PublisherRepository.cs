using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        PublisherRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Publisher entity)
        {
            _db.Publishers.Update(entity);
            await SaveChangesAsync();
        }
    }
}
