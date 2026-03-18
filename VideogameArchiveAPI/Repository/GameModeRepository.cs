using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class GameModeRepository : GenericRepository<GameMode>, IGameModeRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        GameModeRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(GameMode entity)
        {
            _db.GameModes.Update(entity);
            await SaveChangesAsync();
        }
    }
}
