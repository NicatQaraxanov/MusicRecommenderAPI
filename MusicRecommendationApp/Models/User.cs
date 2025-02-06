using MusicRecommendationApp.Models.Abstraction;
using System.Text.Json.Serialization;

namespace MusicRecommendationApp.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        [JsonIgnore]
        public ICollection<Rating> Ratings { get; set; }
    }
}
