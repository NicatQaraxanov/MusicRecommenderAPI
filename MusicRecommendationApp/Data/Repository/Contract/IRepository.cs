using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Data.Repository.Contract
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        ICollection<T> GetAll();
    }
}
