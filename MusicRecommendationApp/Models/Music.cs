using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Models
{
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
