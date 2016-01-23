using System.Linq;

namespace bowlgames_api.Models
{
    public static class BowlGamesContextExtensions
    {
        public static void EnsureSeedData(this BowlGamesContext context)
        {
            if (!context.Teams.Any())
            {
                context.Teams.AddRange(
                    new Team { Id = 1, Name = "Michigan" },
                    new Team { Id = 2, Name = "Ohio State"}
                );

                context.SaveChanges();
            }
        }
    }
}
