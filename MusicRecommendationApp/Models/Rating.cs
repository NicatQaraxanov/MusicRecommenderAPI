using MusicRecommendationApp.Models.Abstraction;

namespace MusicRecommendationApp.Models
{
    public class Rating : BaseEntity
    {
        //This service is not for Adding/Updating an so on. Because of that we dont use any data annotations wich checks range or something else.
        public int Value { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int MusicId { get; set; }
        public Music? Music { get; set; }
    }
}
