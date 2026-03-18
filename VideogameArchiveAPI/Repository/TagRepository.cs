using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        TagRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Tag entity)
        {
            _db.Tags.Update(entity);
            await SaveChangesAsync();
        }
    }
}
