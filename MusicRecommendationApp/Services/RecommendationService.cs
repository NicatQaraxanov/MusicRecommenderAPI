using MusicRecommendationApp.Data.Repository.Contract;
using MusicRecommendationApp.Models;
using MusicRecommendationApp.Services.Contract;
using NReco.CF.Taste.Impl.Common;
using NReco.CF.Taste.Impl.Model;
using NReco.CF.Taste.Impl.Recommender;
using NReco.CF.Taste.Impl.Similarity;
using NReco.CF.Taste.Model;
using System;

namespace MusicRecommendationApp.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly IRepository<Music> _musicRepository;
        private readonly IRepository<Rating> _ratingRepository;

        public RecommendationService(IRepository<Music> musicRepository, IRepository<Rating> ratingRepository)
        {
            _musicRepository = musicRepository;
            _ratingRepository = ratingRepository;
        }

        public List<Music> GetRecommendations(int userId)
        {
            var dataModel = LoadDataModel();

            //This tool figures out how similar music are based on how users have rated them.
            var similarity = new LogLikelihoodSimilarity(dataModel);

            //This tool uses the similarity tool to suggest music that the user might like.
            var recommender = new GenericBooleanPrefItemBasedRecommender(dataModel, similarity);

            //Generate at least 5 recommendations
            var recommendedItems = recommender.Recommend(userId, 5, null);

            //Map recommended item IDs to Music objects
            var recommendedMusic = recommendedItems
                .Select(ri => _musicRepository.GetById((int)ri.GetItemID()))
                .Where(m => m != null)
                .ToList();

            return recommendedMusic;
        }

        //Get all the ratings from the database and organize them in a way the recommendation system can understand.
        public IDataModel LoadDataModel()
        {
            var ratings = _ratingRepository.GetAll().ToList();
            var data = new FastByIDMap<IList<IPreference>>();

            foreach (var rating in ratings)
            {
                if (!data.ContainsKey(rating.UserId))
                {
                    data.Put(rating.UserId, new List<IPreference>());
                }

                data.Get(rating.UserId).Add(new GenericPreference(rating.UserId, rating.MusicId, rating.Value));
            }

            var newData = new FastByIDMap<IPreferenceArray>(data.Count());
            foreach (var entry in data.EntrySet())
            {
                var prefList = (List<IPreference>)entry.Value;
                newData.Put(entry.Key, (IPreferenceArray)new BooleanUserPreferenceArray(prefList));
            }

            return new GenericDataModel(newData);
        }
    }
}
