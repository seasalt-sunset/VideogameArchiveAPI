using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        ReviewRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Review entity)
        {
            _db.Reviews.Update(entity);
            await SaveChangesAsync();
        }
    }
}
