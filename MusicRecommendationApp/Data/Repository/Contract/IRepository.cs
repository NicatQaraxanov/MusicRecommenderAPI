using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Data.Repository.Contract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);

        Task<ICollection<T>> GetAllAsync();
    }
}
