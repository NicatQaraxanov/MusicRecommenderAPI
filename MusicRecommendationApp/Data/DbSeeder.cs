using Microsoft.EntityFrameworkCore;

namespace MusicRecommendationApp.Data
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.Migrate();

            //TODO: Seed data
        }
    }
}
