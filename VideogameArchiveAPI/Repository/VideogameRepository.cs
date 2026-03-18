using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class VideogameRepository : GenericRepository<Videogame>, IVideogameRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        VideogameRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Videogame entity)
        {
            _db.Videogames.Update(entity);
            await SaveChangesAsync();
        }
    }
}
