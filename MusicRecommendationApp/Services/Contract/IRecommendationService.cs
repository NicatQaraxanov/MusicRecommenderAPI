using MusicRecommendationApp.Models;
using NReco.CF.Taste.Model;

namespace MusicRecommendationApp.Services.Contract
{
    public interface IRecommendationService
    {
        List<Music> GetRecommendations(int userId);

        IDataModel LoadDataModel();
    }
}
