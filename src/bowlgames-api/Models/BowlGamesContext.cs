using Microsoft.Data.Entity;

namespace bowlgames_api.Models
{
    public class BowlGamesContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Team>()
                .Property(b => b.Name)
                .HasMaxLength(255);
        }
    }
}
