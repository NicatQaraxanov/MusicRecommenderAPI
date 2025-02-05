using Microsoft.EntityFrameworkCore;
using MusicRecommendationApp.Data.Repository.Contract;
using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(d => d.Id == id);
        }
    }
}
