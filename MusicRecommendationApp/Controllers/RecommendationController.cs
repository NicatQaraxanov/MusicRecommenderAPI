using Microsoft.AspNetCore.Mvc;
using MusicRecommendationApp.Models;
using MusicRecommendationApp.Services.Contract;

namespace MusicRecommendationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService _recommendationService;

        public RecommendationController(IRecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }

        [HttpGet("{userId}")]
        public async Task<IEnumerable<Music>> Get(int userId)
        {
            var recommendations = await _recommendationService.GetRecommendationsAsync(userId);
            return recommendations;
        }
    }
}
