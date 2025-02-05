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

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(d => d.Id == id);
        }
    }
}
