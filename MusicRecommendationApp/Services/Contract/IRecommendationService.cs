using MusicRecommendationApp.Models;
using NReco.CF.Taste.Model;

namespace MusicRecommendationApp.Services.Contract
{
    public interface IRecommendationService
    {
        Task<List<Music>> GetRecommendationsAsync(int userId);

        Task<IDataModel> LoadDataModelAsync();
    }
}
