using Microsoft.EntityFrameworkCore;
using MusicRecommendationApp.Models;

namespace MusicRecommendationApp.Data
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
            {
                new User { Username = "tnqaraxanov_" },
                new User { Username = "qr_xnv" },
                new User { Username = "music_lover_123" },
                new User { Username = "jazz_fan_88" },
                new User { Username = "rock_n_roll_forever" },
                new User { Username = "classical_music_fan" },
                new User { Username = "pop_music_fanatic" }
            };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Musics.Any())
            {
                var music = new List<Music>
            {
                new Music { Name = "Song 1", Author = "Artist 1" },
                new Music { Name = "Song 2", Author = "Artist 2" },
                new Music { Name = "Song 3", Author = "Artist 3" },
                new Music { Name = "Song 4", Author = "Artist 4" },
                new Music { Name = "Song 5", Author = "Artist 5" },
                new Music { Name = "Song 6", Author = "Artist 6" },
                new Music { Name = "Song 7", Author = "Artist 7" },
                new Music { Name = "Song 8", Author = "Artist 8" },
                new Music { Name = "Song 9", Author = "Artist 9" },
                new Music { Name = "Song 10", Author = "Artist 10" }
            };
                context.Musics.AddRange(music);
                context.SaveChanges();
            }

            if (!context.Ratings.Any())
            {
                var ratings = new List<Rating>
            {
                new Rating { UserId = 1, MusicId = 1, Value = 5 },
                new Rating { UserId = 1, MusicId = 2, Value = 3 },
                new Rating { UserId = 2, MusicId = 1, Value = 4 },
                new Rating { UserId = 2, MusicId = 3, Value = 2 },
                new Rating { UserId = 3, MusicId = 4, Value = 5 },
                new Rating { UserId = 3, MusicId = 5, Value = 4 },
                new Rating { UserId = 4, MusicId = 6, Value = 3 },
                new Rating { UserId = 4, MusicId = 7, Value = 5 },
                new Rating { UserId = 5, MusicId = 8, Value = 4 },
                new Rating { UserId = 5, MusicId = 9, Value = 2 },
                new Rating { UserId = 6, MusicId = 10, Value = 5 },
                new Rating { UserId = 6, MusicId = 1, Value = 4 },
                new Rating { UserId = 7, MusicId = 2, Value = 4 },
                new Rating { UserId = 7, MusicId = 3, Value = 5 }
            };
                context.Ratings.AddRange(ratings);
                context.SaveChanges();
            }
        }
    }
}
