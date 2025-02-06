using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Data.Repository.Contract
{
    // Didn't add POST/PUT/DELETE because we assume that this is a separate service that only fetches data from the database.
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);

        Task<ICollection<T>> GetAllAsync();
    }
}
