using MusicRecommendationApp.Models.Abstraction;
using System.Text.Json.Serialization;

namespace MusicRecommendationApp.Models
{
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }

        [JsonIgnore]
        public ICollection<Rating> Ratings { get; set; }
    }
}
