using VideogameArchiveAPI.Data;
using VideogameArchiveAPI.Models.Entities;
using VideogameArchiveAPI.Repository.Interfaces;

namespace VideogameArchiveAPI.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly VideogameArchiveAPIDbContext _db;

        UserRepository(VideogameArchiveAPIDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(User entity)
        {
            _db.Users.Update(entity);
            await SaveChangesAsync();
        }
    }
}
