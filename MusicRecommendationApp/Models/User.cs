using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
